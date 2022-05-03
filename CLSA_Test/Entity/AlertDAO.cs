﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLSA_Test.Entity
{
    public class AlertDAO
    {

        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            this.alerts.Add(id, time);
            return id;
        }

        public DateTime GetAlert(Guid id)
        {
            return this.alerts[id];
        }


    }

}