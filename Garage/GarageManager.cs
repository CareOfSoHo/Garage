using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Garage
{
    public class GarageManager
    {
        private readonly IGarageHandler handler;
        private readonly IUi ui;
        //private IUi i_UI = new IUi();

        internal GarageManager(IGarageHandler handler, IUi ui)
        {
            this.handler = handler;
            this.ui = ui;

            Run();
            
        }

        //internal IUi I_UI => i_UI;

        //public IUi I_UI { get => i_UI; set => i_UI = value; }

        private void Run()
        {
            ui.Menu();
        }

        //skriva ut menyn

        // de andra metoderna här också? flytta från garageHandlern
    }
}
