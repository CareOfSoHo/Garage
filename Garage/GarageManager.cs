using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Garage
{
    internal class GarageManager
    {
        private readonly IGarageHandler handler;
        private readonly IUi ui;

        public GarageManager(IGarageHandler handler, IUi ui)
        {
            this.handler = handler;
            this.ui = ui;

            Run();
            
        }

        private void Run()
        {
            ui.Menu();
        }

        //skriva ut menyn

        // de andra metoderna här också? flytta från garageHandlern
    }
}
