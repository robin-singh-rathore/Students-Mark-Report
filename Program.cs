
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace STUDENTS_MARKS_REPORT
{

    class CStudentDetails 
    {

        public string studentname;

        public int[] studentmarks = new int[6];

        public int totalmarks;

        public float per;

      

    }



    class CStudents
    {

        public List<CStudentDetails> studList = new List<CStudentDetails>();



        public int MaxStudents;




        public int AddRecord(string name, int[] marks )
        {

            CStudentDetails stud = new CStudentDetails();

            stud.studentname = name;

            stud.studentmarks = marks;

            stud.totalmarks = 0;

            for (int i = 0; i < 6; i++)

                stud.totalmarks += stud.studentmarks[i];


            stud.per = Convert.ToSingle(stud.totalmarks * 100) / 600;

          
            
            studList.Add(stud);

            MaxStudents = studList.Count;

            return 1;

        }


    }



    class Program
    {




        static public CStudents theStudents = new CStudents();
        
        static public void ViewRecords()
        {



            Console.WriteLine("\n___Student's_______Reporting_____________________________________________________________");
            Console.WriteLine("");


            Console.WriteLine("SNo Student Name       Java    SE     NS    AWP    CG    E com.  Total  Percentage");
            Console.WriteLine("                        100    100    100   100    100   100      600       % ");

            Console.WriteLine("__________________________________________________________________________________________");



            for (int i = 0; i < theStudents.MaxStudents; i++)
            {

                Console.Write("{0, -5}", i + 1);

                Console.Write("{0, -19}", theStudents.studList[i].studentname);

                Console.Write("{0, -7}", theStudents.studList[i].studentmarks[0]);

                Console.Write("{0, -7}", theStudents.studList[i].studentmarks[1]);

                Console.Write("{0, -7}", theStudents.studList[i].studentmarks[2]);

                Console.Write("{0, -7}", theStudents.studList[i].studentmarks[3]);

                Console.Write("{0, -7}", theStudents.studList[i].studentmarks[4]);

                Console.Write("{0, -7}", theStudents.studList[i].studentmarks[5]);

                Console.Write("{0, -7}", theStudents.studList[i].totalmarks);

                Console.Write("{0, -7}", theStudents.studList[i].per);
   
                
                Console.WriteLine();

            }

            Console.WriteLine("__________________________________________________________________________________________");

        }


        static public void InputRecords()
        {
            string[] subj = new string[6];
            subj[0] = "  Java ";
            subj[1] = "    SE ";
            subj[2] = "    NS ";
            subj[3] = "   AWP ";
            subj[4] = "    CG ";
            subj[5] = "E Com. ";


            Console.Write("Student Name : ");


            string name;

           
            int[] marks = new int[6];

            name = Console.ReadLine();

            Console.WriteLine("\nEnter Student Marks  ");


            for (int i = 0; i < subj.Length; i++)
            {

                Console.Write(subj[i] + " Mark : ");

                marks[i] = Convert.ToInt32(Console.ReadLine());
            }



            theStudents.AddRecord(name, marks);

        }



        static void Main(string[] args)
        {


            Console.WriteLine("\t\t\t\t\t\tStudent MarkList Application");

            Console.Write("\nEnter the Total number  of students: ");

            int numStudents = -1;

            string s = Console.ReadLine();

            numStudents = Convert.ToInt32(s);



            for (int i = 1; i <= numStudents; i++)
            {

                Console.WriteLine("\nEnter " + i.ToString() + " Student Information(s)\n");

                InputRecords();

            }

            ViewRecords();

            char ch = Console.ReadKey().KeyChar;

        }

    }


}

