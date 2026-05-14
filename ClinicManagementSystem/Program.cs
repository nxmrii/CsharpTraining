namespace ClinicManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ── REGION 1: System Storage ───────────────────────────────────── 

            // Capacity constants 
            const int MAX_PATIENTS = 3;
            const int MAX_DOCTORS = 2;
            const int MAX_APPOINTMENTS = 3;

            // Patient slots 
            string p1Name = "";
            int p1Age = 0;
            string p1Phone = "";
            bool p1Active = false;

            string p2Name = "";
            int p2Age = 0;
            string p2Phone = "";
            bool p2Active = false;

            string p3Name = "";
            int p3Age = 0;
            string p3Phone = "";
            bool p3Active = false;
            int patientCount = 0;

            // Doctor slots 
            string d1Name = "";
            string d1Spec = "";
            double d1Fee = 0;
            bool d1Active = false;
            string d2Name = "";
            string d2Spec = "";
            double d2Fee = 0;
            bool d2Active = false;
            int doctorCount = 0;

            // Appointment slots 
            string a1Patient = "";
            string a1Doctor = "";
            string a1Date = "";
            string a1Status = "";
            bool a1Active = false;
            string a2Patient = "";
            string a2Doctor = "";
            string a2Date = "";
            string a2Status = "";
            bool a2Active = false;
            string a3Patient = "";
            string a3Doctor = "";
            string a3Date = "";
            string a3Status = "";
            bool a3Active = false;
            int appointmentCount = 0;


            //───────────────────────── Region 2 ─────────────────────────────────────────────── 


            bool exit = false;
            bool patientManagementExit;
            bool doctorManagementExit;
            bool apointmentManagementExit;
            while (exit == false)
            {
                Console.WriteLine(" CLINIC MANAGMENT SYSTEM ");
                Console.WriteLine("1. Patint Managment");
                Console.WriteLine("2. Doctor Managment");
                Console.WriteLine("3. Appointment Managment");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");

                int choic = Convert.ToInt32(Console.ReadLine());
                switch (choic)
                {
                    case 1:
                        
                        patientManagementExit=false;   
                        while (patientManagementExit==false)
                        {
                            
                            Console.WriteLine(" PATIENT MANAGEMENT ");
                            Console.WriteLine("1. Add new Patint");
                            Console.WriteLine("2. Display All Patients");
                            Console.WriteLine("3. Update Patient Phone");
                            Console.WriteLine("4. Delete Patient");
                            Console.WriteLine("0. Back to Main Menu");
                            Console.Write("Enter your choic: ");

                            int Pchoose = Convert.ToInt32(Console.ReadLine());
                            switch (Pchoose)
                            {

                                case 1:
                                    Console.Write("Add New Patient");

                                    //check clinic full
                                    if(patientCount == MAX_PATIENTS)
                                    {
                                        Console.WriteLine("Clinic is full. Cannot add more patients."); 
                                        break;
                                    }
                                    
                                    // read patient name
                                        Console.Write("Enter patient name: ");
                                        string name = Console.ReadLine();
                                        if (name == "")
                                        {
                                            Console.WriteLine("Invalid name.");
                                            break;
                                        }

                                    //read age
                                    Console.Write("Enter age: ");
                                    int age = Convert.ToInt32(Console.ReadLine());
                                    if (age < 1 || age > 120)
                                    {
                                        Console.WriteLine("error");
                                        break;
                                    }

                                    //read phone
                                    Console.Write("Enter phone number: ");
                                    string phone = Console.ReadLine();

                                    // read free slot
                                    if (p1Active == false)
                                    {
                                        p1Name = name;
                                        p1Age = age;
                                        p1Phone = phone;
                                        p1Active = true;
                                    }
                                    else if (p2Active == false)
                                    {
                                        p2Name = name;
                                        p2Age = age;
                                        p2Phone = phone;
                                        p2Active = true;
                                    }
                                    else if (p3Active == false)
                                    {
                                        p3Name = name;
                                        p3Age = age;
                                        p3Phone = phone;
                                        p3Active = true;
                                    }

                                    patientCount++;
                                    Console.WriteLine("Patient added successfully");
                                    break;

                                case 2:
                                    Console.WriteLine("Display All Patients");

                                    // check if there is patient
                                    if (patientCount == 0)
                                    {
                                        Console.WriteLine("No patients registered.");
                                        break;
                                    }

                                    //check each slot
                                    int displayNum = 1;
                                    if (p1Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("Patient Name" + p1Name);
                                        Console.WriteLine("Patient Age" + p1Age);
                                        Console.WriteLine("Patient Phone" + p1Phone);
                                        displayNum++;
                                    }

                                    if (p2Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("Patient Name" + p2Name);
                                        Console.WriteLine("Patient Age" + p2Age);
                                        Console.WriteLine("Patient Phone" + p2Phone);
                                        displayNum++;
                                    }

                                    if (p3Active)
                                    {
                                        Console.WriteLine("Patient #" + displayNum);
                                        Console.WriteLine("Patient Name" + p3Name);
                                        Console.WriteLine("Patient Age" + p3Age);
                                        Console.WriteLine("Patient Phone" + p3Phone);
                                        displayNum++;
                                    }

                                    break;

                                case 3:
                                    Console.WriteLine("Update Patient Phone");
                                    // read patient name
                                    Console.Write("Enter patient name: ");
                                    string searchName = Console.ReadLine();
                                    
                                    // check patinet 1
                                    if(p1Active && p1Name == searchName)
                                    {
                                        Console.Write("Enter new phone: ");
                                        string newPhone = Console.ReadLine();
                                        p1Phone = newPhone;
                                        Console.WriteLine("Updated..");
                                    }
                                    // check patinet 2
                                    if (p2Active && p2Name == searchName)
                                    {
                                        Console.Write("Enter new phone: ");
                                        string newPhone = Console.ReadLine();
                                        p2Phone = newPhone;
                                        Console.WriteLine("Updated..");
                                    }
                                    // check patinet 3
                                    if (p3Active && p3Name == searchName)
                                    {
                                        Console.Write("Enter new phone: ");
                                        string newPhone = Console.ReadLine();
                                        p3Phone = newPhone;
                                        Console.WriteLine("Updated..");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }

                                    break;

                                case 4:
                                    Console.WriteLine("Delete Patient");

                                    //read patient name
                                    Console.Write("Enter patient name: ");
                                    string deleteName = Console.ReadLine();

                                    //check patient 1 
                                    if (p1Active && p1Name == deleteName)
                                    {
                                        p1Active = false;
                                        p1Name = "";
                                        p1Age = 0;
                                        p1Phone = "";
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p2Active && p2Name == deleteName)
                                    {
                                        p2Active = false;
                                        p2Name = "";
                                        p2Age = 0;
                                        p2Phone = "";
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else if (p3Active && p3Name == deleteName)
                                    {
                                        p3Active = false;
                                        p3Name = "";
                                        p3Age = 0;
                                        p3Phone = "";
                                        patientCount--;
                                        Console.WriteLine("Patient deleted.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Patient not found.");
                                    }
                                    break;

                                case 0:
                                    Console.WriteLine("Back to Main Menu");
                                    patientManagementExit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }

                        break;













                    case 2:
                        doctorManagementExit = false;
                        while (doctorManagementExit = false)
                        {
                            Console.Clear();
                            Console.WriteLine("  DOCTOR MANAGEMENT ");
                            Console.WriteLine("1. Add new Doctor");
                            Console.WriteLine("2. Display All Doctors");
                            Console.WriteLine("3.  Update Consultation Fee");
                            Console.WriteLine("4. Delete Doctor ");
                            Console.WriteLine("0. Back to Main Menu");
                            Console.Write("Enter your choic: ");

                            int Pchoose = Convert.ToInt32(Console.ReadLine());
                            switch (Pchoose)
                            {

                                case 1:
                                    Console.WriteLine("Add New Doctor");
                                    break;

                                case 2:
                                    Console.WriteLine("Display All Doctors");
                                    break;

                                case 3:
                                    Console.WriteLine(" Update Consultation Fee");
                                    break;

                                case 4:
                                    Console.WriteLine("Delete Doctor");
                                    break;

                                case 0:
                                    Console.WriteLine("Back to Main Menu");
                                    doctorManagementExit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }
                        break;



                    case 3:

                        apointmentManagementExit = false;
                        while (apointmentManagementExit == false)
                        {
                            Console.Clear();
                            Console.WriteLine("  APPOINTMENT MANAGEMENT ");
                            Console.WriteLine("1. Book New Appointment");
                            Console.WriteLine("2. Display All Appointments");
                            Console.WriteLine("3. Update Appointment Status");
                            Console.WriteLine("4.  Cancel Appointment");
                            Console.WriteLine("0. Back to Main Menu");
                            Console.Write("Enter your choic: ");

                            int Pchoose = Convert.ToInt32(Console.ReadLine());
                            switch (Pchoose)
                            {

                                case 1:
                                    Console.WriteLine("Book New Appointment");
                                    break;

                                case 2:
                                    Console.WriteLine("Display All Appointments");
                                    break;

                                case 3:
                                    Console.WriteLine("Update Appointment Status");
                                    break;

                                case 4:
                                    Console.WriteLine(" Cancel Appointment");
                                    break;

                                case 0:
                                    Console.WriteLine("Back to Main Menu");
                                    apointmentManagementExit = true;
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }

                        break;

                    case 0:
                        Console.WriteLine("Exiting Program..");
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("do NOT exit the program ");
                        break;
                }
            }



         


        }
    }
}
