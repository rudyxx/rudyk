using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_4_3
{
    // 12) change methods of sorting to properties

    // 1) implement interface IComparable
    public class Animal : IComparable
    {
        // 2) declare properties and parameter constructor
        public string Genus { get; set; }
        public int Weight { get; set; }

        public Animal(string genus, int weight)
        {
            Genus = genus;
            Weight = weight;
        }

        // 3) implement method ComareTo()
        // it comares Genus of type string - return result of method String.Compare 
        // for this.genus and argument object
        // don't forget to cast object to Animal
        int IComparable.CompareTo(object arg)
        {
            Animal temp = arg as Animal;
            if (arg != null)
                return String.Compare(this.Genus, temp.Genus);
            else
                throw new ArgumentException("Parameter is not a Animal!");
        }

        // 4) declare methods SortWeightAscending(), SortGenusDescending()
        // they are static and return IComparer
        // return type is custed from constructor of classes SortWeightAscendingHelper, 
        // SortGenusDescendingHelper calling 
        public static IComparer SortWeightAscending
        { get { return (IComparer)new SortWeightAscendingHelper(); } }
        

         public static IComparer SortGenusDescending
            { get { return (IComparer)new SortGenusDescendingHelper(); } }
        

        // 5) declare 2 nested private classes SortWeightAscendingHelper, SortGenusDescendingHelper 
        // they implement interface IComparer
        // every nested class has implemented method Comare with 2 parameters of object and return int
        // class SortWeightAscendingHelper sort weight by ascending
        // class SortGenusDescendingHelper sort genus by descending

        private class SortWeightAscendingHelper : IComparer
        {
            int IComparer.Compare(object ob1, object ob2 )
            {
                Animal temp1 = ob1 as Animal;
                Animal temp2 = ob2 as Animal;
                if(temp1 != null && temp2 != null)
                    return temp1.Weight.CompareTo(temp2.Weight);
                else
                    throw new ArgumentException("Parameter is not an Animal!");
            }
        }

        private class SortGenusDescendingHelper : IComparer
        {
            int IComparer.Compare(object ob1, object ob2)
            {
                Animal temp1 = ob1 as Animal;
                Animal temp2 = ob2 as Animal;
                if (temp1 != null && temp2 != null)
                    return String.Compare(temp1.Genus, temp2.Genus);
                else
                    throw new ArgumentException("Parameter is not an Animal!");
            }
        }

    }
}
