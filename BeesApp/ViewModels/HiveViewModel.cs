using Bees.ClientData.Models;
using Bees.SharedData.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeesApp.ViewModels
{
    public class HiveViewModel
    {
        public Hive Hive { get; set; }

        public string HiveType { get => Enum.GetName(typeof(eHiveType), Hive.HiveType); }

        public HiveViewModel()
        {
            this.Hive = new Hive();
        }
    }
}
