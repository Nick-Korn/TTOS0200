using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Technology
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public bool IsPcComponent { get; set; }
        public bool Works { get; set; }
        public Technology(string type, string model, int modelYear, bool isPcComponent, bool works)
        {
            Type = type;
            Model = model;
            ModelYear = modelYear;
            IsPcComponent = isPcComponent;
            Works = works;
        }
        public string PrintData()
        {
            string outPut = string.Format("Type: {0}, Model: {1}, Model year: {2}, Is PC component: {3}, Works: {4}",
                Type, Model, ModelYear, IsPcComponent, Works);
            return outPut;
        }
    }
}
