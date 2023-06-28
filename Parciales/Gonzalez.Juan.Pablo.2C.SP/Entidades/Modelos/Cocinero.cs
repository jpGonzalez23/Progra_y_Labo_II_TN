using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;
using Entidades.DataBase;


namespace Entidades.Modelos
{
    public delegate void DelegadoDemoraAtencion(double demora);

    public delegate void DelegadoNuevoIngreso(IComestible menu);

    public class Cocinero<T> where T : IComestible, new ()
    {
        public event DelegadoDemoraAtencion OnDemora;
        public event DelegadoNuevoIngreso OnIngreso;

        private int cantPedidosFinalizados;
        private string nombre;
        private double demoraPreparacionTotal;

        private CancellationTokenSource cancellation;
        private T menu;
        private Task tarea;



        public Cocinero(string nombre)
        {
            this.nombre = nombre;
        }


        public bool HabilitarCocina
        {
            //get
            //{
            //    return this.tarea != null && (this.tarea.Status == TaskStatus.Running
            //                              || this.tarea.Status == TaskStatus.WaitingToRun
            //                              || this.tarea.Status == TaskStatus.WaitingForActivation);
            //}
            //set
            //{
            //    if (value && !this.HabilitarCocina)
            //    {
            //        this.cancellation = new CancellationTokenSource();
            //        this.IniciarIngreso();
            //    }
            //    else
            //    {
            //        this.cancellation.Cancel();
            //    }
            //}

            get
            {
                return this.tarea is not null && (this.tarea.Status == TaskStatus.Running
                                              || this.tarea.Status == TaskStatus.WaitingToRun
                                              || this.tarea.Status == TaskStatus.WaitingForActivation);
            }
            set
            {
                if (value && !this.HabilitarCocina)
                {
                    this.cancellation = new CancellationTokenSource();
                    this.IniciarIngreso();
                }
                else
                {
                    this.cancellation.Cancel();
                }
            }
        }

        public double TiempoMedioDePreparacion 
        { 
            get => this.cantPedidosFinalizados == 0 ? 0 : this.demoraPreparacionTotal / this.cantPedidosFinalizados; 
        }

        public string Nombre { get => nombre; }

        public int CantPedidosFinalizados { get => this.cantPedidosFinalizados; }

        private void IniciarIngreso()
        {
            //this.tarea = Task.Run(() =>
            //{
            //    while (this.cancellation.IsCancellationRequested)
            //    {
            //        this.NotificarNuevoIngreso();

            //        this.EsperarProximoIngreso();

            //        this.cantPedidosFinalizados++;

            //        DataBase.DataBaseManager.GuardarTicket<Hamburguesa>(this.Nombre, );
            //    }
            //});

            CancellationToken token = this.cancellation.Token;

            this.tarea = Task.Run(() =>
            {
                while (!this.cancellation.IsCancellationRequested)
                {
                    this.NotificarNuevoIngreso();
                    this.EsperarProximoIngreso();
                    this.cantPedidosFinalizados++;
                    
                    try
                    {
                        DataBaseManager.GuardarTicket(this.nombre, this.menu);
                    }
                    catch(DataBaseManagerException ex)
                    {
                        FileManager.Guardar(ex.Message, "logs.txt", true);
                    }
                }
            }, token);
        }

        private void NotificarNuevoIngreso()
        {
            if (this.OnIngreso is not null)
            {
                this.menu = new T();
                this.menu.IniciarPreparacion();
                this.OnIngreso.Invoke(this.menu);
            }
        }

        private void EsperarProximoIngreso()
        {
            //if (OnIngreso is not null)
            //{
            //    this.HabilitarCocina = false;
            //    Thread.Sleep(1000);

            //}

            int tiempoEspera = 0;

            while (this.OnDemora is not null && !this.menu.Estado && this.cancellation.IsCancellationRequested)
            {
                tiempoEspera++;
                this.OnDemora.Invoke(tiempoEspera);
                Thread.Sleep(1000);
            }

            this.demoraPreparacionTotal += tiempoEspera;
        }
    }
}
