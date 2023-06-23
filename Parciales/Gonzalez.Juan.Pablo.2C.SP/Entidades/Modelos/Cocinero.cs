﻿using Entidades.Exceptions;
using Entidades.Files;
using Entidades.Interfaces;


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
            get
            {
                return this.tarea != null && (this.tarea.Status == TaskStatus.Running
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

        private void IniciarIngreso()
        {
            this.tarea = Task.Run(() =>
            {
                while (this.cancellation.IsCancellationRequested)
                {
                    this.NotificarNuevoIngreso();
                    
                    this.EsperarProximoIngreso();
                    
                    this.cantPedidosFinalizados++;

                    DataBase.DataBaseManager.GuardarTicket<Hamburguesa>(this.Nombre, );
                }
            });
        }

        private void NotificarNuevoIngreso()
        {
            if (OnIngreso is not null)
            {
                
            }
        }
        private void EsperarProximoIngreso()
        {
            if (OnIngreso is not null)
            {
                this.HabilitarCocina = false;
                Thread.Sleep(1000);

            }
        }
    }
}
