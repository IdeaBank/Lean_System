using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lean_System
{
    enum POSITION
    {
        WORKER, ASDF
    }

    [Serializable]
    class Person : ISerializable
    {
        public Person()
        {
            this.positions.Add(POSITION.WORKER);
            this.positions.Add(POSITION.ASDF);
            this.positions.Add(POSITION.ASDF);
        }

        public string getName()
        {
            MessageBox.Show((POSITION.WORKER == 0).ToString());
            return this.name;
        }

        protected Person(SerializationInfo info, StreamingContext context)
        {
            this.name = info.GetString("Name");
            this.positions = (List<POSITION>)info.GetValue("Position", typeof(List<POSITION>));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", this.name);
            info.AddValue("Position", this.positions);
        }

        private List<POSITION> positions = new List<POSITION>();
        private string name = "ASDF";
    }

}
