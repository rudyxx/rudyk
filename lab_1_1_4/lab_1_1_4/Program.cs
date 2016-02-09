using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1_1_4
{
    public class Program
    {

        // 1) declare enum ComputerType
        public enum ComputerType { Desktop, Laptop, Server };
        // 2) declare struct Computer
        public struct Computer
        {
            public ComputerType typeOfPC;
            public int cpu;
            public float frequency;
            public int memory;
            public int hdd;
        };

        static void Main(string[] args)
        {

            int totalComputersAmount = 0;
            int totalDesctopComputers = 0;
            int totalLaptopComputers = 0;
            int totalServerComputers = 0;

            int largestHDD = 0;
            int lowestCPU = int.MaxValue;

            // 3) declare jagged array of computers size 4 (4 departments)
            Computer[][] departments = new Computer[4][];

            // 4) set the size of every array in jagged array (number of computers)
            departments[0] = new Computer[5];
            departments[1] = new Computer[3];
            departments[2] = new Computer[5];
            departments[3] = new Computer[4];

            // 5) initialize array
            // Note: use loops and if-else statements            
            departments[0][0].typeOfPC = ComputerType.Desktop; 
            departments[0][1].typeOfPC = ComputerType.Desktop; 
            departments[0][2].typeOfPC = ComputerType.Laptop; 
            departments[0][3].typeOfPC = ComputerType.Laptop; 
            departments[0][4].typeOfPC = ComputerType.Server; 

            departments[1][0].typeOfPC = ComputerType.Laptop; 
            departments[1][1].typeOfPC = ComputerType.Laptop; 
            departments[1][2].typeOfPC = ComputerType.Laptop; 

            departments[2][0].typeOfPC = ComputerType.Desktop; 
            departments[2][1].typeOfPC = ComputerType.Desktop; 
            departments[2][2].typeOfPC = ComputerType.Desktop; 
            departments[2][3].typeOfPC = ComputerType.Laptop; 
            departments[2][4].typeOfPC = ComputerType.Laptop; 

            departments[3][0].typeOfPC = ComputerType.Desktop; 
            departments[3][1].typeOfPC = ComputerType.Laptop; 
            departments[3][2].typeOfPC = ComputerType.Server; 
            departments[3][3].typeOfPC = ComputerType.Server; 

            for (int i = 0; i < departments.Length; i++ )
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if(departments[i][j].typeOfPC == ComputerType.Desktop)
                    {
                        departments[i][j].cpu = 4;
                        departments[i][j].frequency = 2.5f;
                        departments[i][j].memory = 6;
                        departments[i][j].hdd = 500;
                    }
                    else if (departments[i][j].typeOfPC == ComputerType.Laptop)
                    {

                        departments[i][j].cpu = 2;
                        departments[i][j].frequency = 1.7f;
                        departments[i][j].memory = 4;
                        departments[i][j].hdd = 250;
                    }
                    else if (departments[i][j].typeOfPC == ComputerType.Server)
                    {

                        departments[i][j].cpu = 8;
                        departments[i][j].frequency = 3.0f;
                        departments[i][j].memory = 16;
                        departments[i][j].hdd = 2000;
                    }
                }
            }

            //5.1 a few changes beyond to make it more fun
            //the most largest HDD
            departments[3][3].hdd = 3500;

            //tiny CPU
            departments[0][2].cpu = 1;


            // 6) count total number of every type of computers
            // 7) count total number of all computers
            // Note: use loops and if-else statements
            // Note: use the same loop for 6) and 7)
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].typeOfPC == ComputerType.Desktop)
                    {
                        totalComputersAmount++;
                        totalDesctopComputers++;
                    }
                    else if (departments[i][j].typeOfPC == ComputerType.Laptop)
                    {

                        totalComputersAmount++;
                        totalLaptopComputers++;
                    }
                    else if (departments[i][j].typeOfPC == ComputerType.Server)
                    {

                        totalComputersAmount++;
                        totalServerComputers++;
                    }
                }
            }

            // 8) find computer with the largest storage (HDD) - 
            // compare HHD of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            int[] topHDD = new int[2];
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].hdd > largestHDD)
                    {
                        largestHDD = departments[i][j].hdd;
                        topHDD[0] = i;
                        topHDD[1] = j;
                    }
                }
            }
            Console.WriteLine("the largest HDD has computer with [{0}][{1}] index. His HDD = {2} GB", topHDD[0], topHDD[1], departments[topHDD[0]][topHDD[1]].hdd);

            // 9) find computer with the lowest productivity (CPU and memory) - 
            // compare CPU and memory of every computer between each other; 
            // find position of this computer in array (indexes)
            // Note: use loops and if-else statements
            // Note: use logical oerators in statement conditions
            int[]  worstCPU = new int[2];
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].cpu < lowestCPU)
                    {
                        lowestCPU = departments[i][j].cpu;
                        worstCPU[0] = i;
                        worstCPU[1] = j;
                    }
                }
            }
            Console.WriteLine("the worstest CPU has computer with [{0}][{1}] index. His CPU = {2} cores", worstCPU[0], worstCPU[1], departments[worstCPU[0]][worstCPU[1]].cpu);

            // 10) make desktop upgrade: change memory up to 8
            // change value of memory to 8 for every desktop. Don't do it for other computers
            // Note: use loops and if-else statements
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    if (departments[i][j].typeOfPC == ComputerType.Desktop)
                    {
                        departments[i][j].memory = 8;
                    }
                }
            }

            Console.WriteLine("\nShow all PC in all departments:");
            //show all computers and all parametrsmethod. 
            for (int i = 0; i < departments.Length; i++)
            {
                for (int j = 0; j < departments[i].Length; j++)
                {
                    Console.WriteLine("Department {0}: Type - {1}; CPU - {2}; frequency - {3}; memory - {4}; HDD - {5}.",
                        i, departments[i][j].typeOfPC, departments[i][j].cpu, departments[i][j].frequency, departments[i][j].memory, departments[i][j].hdd);
                }
            }

            Console.ReadKey();
        }
    }
}
