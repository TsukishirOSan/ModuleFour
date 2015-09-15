using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**For this assignment, complete the following tasks.  For the structs, just include member variables and a constructor. 
 * Do not create properties at this time.  Include all the variables that you have created up to this point in time.

 * Create a struct to represent a student
 * Create a struct to represent a teacher
 * Create a struct to represent a program
 * Create a struct to represent a course
 * Create an array to hold 5 student structs.
 * Assign values to the fields in at least one of the student structs in the array
 * Using a series of Console.WriteLine() statements, output the values for the student struct that you assigned in the previous step
 * When complete, submit your code in the peer review section.

Challenge (Do not submit the challenge code to the peer assessment area)==> Don't submit note to self

For this challenge, expand on the struct array steps to complete the following:

Use an appropriate looping structure to add values to all student structs in the array by 
 * prompting a user of the application to enter values for fields.

For example, if you created fristName, lastName, address, city fields as an example, 
 * for each of the 5 students in the array, you need to prompt the user for each field in the struct, for each student struct in the array.
Once completed, create another loop to iterate over the array and write the values to the console window
 * 
 * 
*/


namespace ModuleFour
{
    class StructForInfo
    {
        static void Main(string[] args)
        {
            // instanciate the array of type Student, giving it 5 possible student to put in the array.
            Student[] studentsArray = new Student[5];
            // put in students the created and implemented array of student
            Student[] students = CreateAndImplementArrayOfStudents(studentsArray);
            // Dispplay only one student information, the first one entered (C# is 0 indexed)
            OutputStudentStructArray(studentsArray);
            Console.ReadKey();
        }


        #region dedicated to the Student struct
        struct Student
        {
            internal string sFirst;
            internal string sLast;
            internal string sEmail;
            internal DateTime sBirthdate;
            internal string sAddressLine1;
            internal string sAddressLine2;
            internal string sCity;
            internal string sStateOrProvince;
            internal string sZipPostal;
            internal string sCountry;

            internal char sGender;
            internal Decimal sAccountBalance;
            internal float sOverallGPA;
            internal bool sIsEnrolled;

            public Student(string sFirst, string sLast, string sEmail, DateTime sBirthdate, string sAddressLine1, string sAddressLine2,
                string sCity, string sStateOrProvince, string sZipPostal, string sCountry, char sGender, Decimal sAccountBalance,
                float sOverallGPA, bool sIsEnrolled)
            {
                this.sFirst = sFirst;
                this.sLast = sLast;
                this.sEmail = sEmail;
                this.sBirthdate = sBirthdate;

                this.sAddressLine1 = sAddressLine1;
                this.sAddressLine2 = sAddressLine2;
                this.sCity = sCity;
                this.sStateOrProvince = sStateOrProvince;
                this.sZipPostal = sZipPostal;
                this.sCountry = sCountry;

                this.sAccountBalance = sAccountBalance;
                this.sOverallGPA = sOverallGPA;
                this.sGender = sGender;
                this.sIsEnrolled = sIsEnrolled;
            }

        }
        #endregion

        #region dedicated to the Professor struct
        struct Professor
        {
            internal string pFirst;
            internal string pLast;
            internal DateTime pBirthdate;
            internal string pAppointmentTitle; // i.e. "Professor of the Practice of Computer Science; Member of the Faculty of Education"
            internal string pDepartment; // i.e. "Other Academic; Staff"
            internal string pMailingAddress;
            internal string pEmail;
            internal string pField; // i.e. "Computer Science and Programming, C#\n";
            internal string pBuilding;
            internal string pPhone;

            internal string pUnit; // "Microsoft Graduate School of Education; Faculty or Arts and Sciences"

            public Professor(string pFirst, string pLast, DateTime pBirthdate, string pAppointmentTitle, string pDepartment,
                string pMailingAddress, string pEmail, string pField, string pBuilding, string pPhone, string pUnit)
            {
                this.pFirst = pFirst;
                this.pLast = pLast;
                this.pBirthdate = pBirthdate;
                this.pAppointmentTitle = pAppointmentTitle;
                this.pDepartment = pDepartment;
                this.pMailingAddress = pMailingAddress;
                this.pEmail = pEmail;
                this.pField = pField;
                this.pBuilding = pBuilding;
                this.pPhone = pPhone;
                this.pUnit = pUnit;
            }
        }
        #endregion

        #region dedicated to the Course struct
        struct Course
        {
            internal string cName;
            internal string cField; // i.e. "Computer Science and Programming; Data processing"
            internal int cCredits;

            public Course(string cName, string cField, int cCredits)
            {
                this.cName = cName;
                this.cField = cField;
                this.cCredits = cCredits;
            }

        }
        #endregion

        #region dedicated to the UnivProgram struct
        struct UnivProgram
        {
            // creates a list of degrees proposed by the University
            [Flags]
            internal enum UnivDegrees
            {
                BachelorOfScience = 0x01,
                MasterOfScience = 0x02,
                DoctorOfPhilosophy = 0x03,

                AllAvailableDegrees = BachelorOfScience & MasterOfScience & DoctorOfPhilosophy, // && can't be applied to int type
            }

            internal string uName;
            internal UnivDegrees uDegreesProposed;
            internal string uDepartmentHead;

            public UnivProgram(string uName, UnivDegrees uDegreesProposed, string uDepartmentHead)
            {
                this.uName = uName;
                this.uDegreesProposed = uDegreesProposed;
                this.uDepartmentHead = uDepartmentHead;
            }
        }
        #endregion

        #region dedicated to creating an array of type struct Student, implement it and output it and check for DateTime full validity
        private static Student[] CreateAndImplementArrayOfStudents(Student [] studentsArray)
        {
            try
            {
                // m is for maxvalue for Decimal object, f stands dor float in float type
                studentsArray[0] = new Student
                ("Faïza", "Harbi", "faiza.harbi@foo.edu", new DateTime(1982, 3, 6), "797 Foo Avenue", "Residence Baz", "Montpellier", "Hérault", "34070", "FRANCE",
                    'F', 300.02m, 3.9f, true
                );
                studentsArray[1] = new Student
                ("Julien", "Mazet", "julien.mazet@foo.edu", new DateTime(1981, 3, 7), "797 Foo Avenue", "Residence Baz", "Montpellier", "Hérault", "34070", "FRANCE",
                    'M', 1200.50m, 4.0f, false
                );
                studentsArray[2] = new Student
                ("Ivan", "Joule", "ivan.joule@foo.edu", new DateTime(1982, 9, 24), "2 Main Street", "", "Stropia", "", "0407", "MACEDONIA",
                    'M', 500.60m, 3.8f, true
                );
                studentsArray[3] = new Student
                ("Ana", "Blake", "ana.blake@foo.edu", new DateTime(1989, 4, 17), "24 Bazinga Road", "Residence Cooper", "Moscow", "", "101000", "RUSSIA",
                    'F', 300.02m, 3.9f, true
                );
                studentsArray[4] = new Student
                ("Oliver", "Jenkins", "oliver.jenkins@foo.edu", new DateTime(1983, 8, 12), "850 Noob Avenue", "Villa Newbie", "London", "Soho", "W1", "UK",
                    'M', 300.02m, 3.9f, false
                );
            }
            catch (ArgumentOutOfRangeException oor)
            {
                Console.WriteLine("Argument out of range exception caught", Environment.NewLine, oor.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Wrong Date format for output", Environment.NewLine, fe.Message);
            }
            // We need the array implemented to output it in the method below that one
            return studentsArray;
        }

        // Prompts in the console the information regarding the object 
        // of type Student stored in the first "slot" of the array
        private static void OutputStudentStructArray(Student [] studentsArray)
        {
            for (int i = 0; i < studentsArray.Length; i++)
            {
                Console.WriteLine("First Name: {0}{1}" +
                "Last Name: {2}{1}" +
                "email: {3}{1}" +
                "Birthdate: {4:MM/dd/yyyy}{1}{1}" +
                "Address  {5}{1}" + "{6}{1}" +
                "{7}, {8}{1}" +
                "{9}, {10}{1}{1}" +
                "------------{1}" +
                "Account Balance: {11}{1}" +
                "Overall GPA: {12}{1}" +
                "Gender: {13}{1}" +
                "Is the student Currently Enrolled?: {14}",

                studentsArray[i].sFirst, Environment.NewLine, studentsArray[i].sLast, studentsArray[i].sEmail, studentsArray[i].sBirthdate,
                studentsArray[i].sAddressLine1, studentsArray[i].sAddressLine2, studentsArray[i].sCity, studentsArray[i].sStateOrProvince,
                studentsArray[i].sZipPostal, studentsArray[i].sCountry, studentsArray[i].sAccountBalance, studentsArray[i].sOverallGPA,
                studentsArray[i].sGender, studentsArray[i].sIsEnrolled
                );
            }
        }
        #endregion
    }
}

