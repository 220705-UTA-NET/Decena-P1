using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medicines.client
{
    internal class MedicinesDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Amount { get; set; }
        public int Tablets { get; set; }
        public string Price { get; set; }
    }
}
