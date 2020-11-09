using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_20180140004
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exeption
        /* output->*/
        int Tambah(int a, int b); //method

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exeption
        int Kurang(int a, int b); //input

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exeption
        int Kali(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exeption
        int Bagi(int a, int b);

        [OperationContract]
        [FaultContract(typeof(MathFault))] //membuat kelas yang melambangkan exeption
        Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class

    }

    [DataContract]
    public class Koordinat
    {
        private int _x, _y; //atribut
        [DataMember]//membuka koordinat, x,y
        public int X //properties
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y //properties
        {
            get { return _y; }
            set { _y = value; }
        }
    }

    //class MathFault
    [DataContract]
    class MathFault
    {
        [DataMember]
        public string Kode { get; set; }
        [DataMember]
        public string Pesan { get; set; }
    }
}