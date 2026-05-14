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
                        while (true)
                        {
                            Console.Clear();
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
                                    Console.WriteLine("Add New Patient");
                                    break;

                                case 2:
                                    Console.WriteLine("Display All Patients");
                                    break;

                                case 3:
                                    Console.WriteLine("Update Patient Phone");
                                    break;

                                case 4:
                                    Console.WriteLine("Delete Patient");
                                    break;

                                case 0:
                                    Console.WriteLine("Exit");
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }



                    case 2:
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine(" Doctor Managment ");
                            Console.WriteLine("1. Add new Doctor");
                            Console.WriteLine("2. Display All Patients");
                            Console.WriteLine("3. Update Patient Phone");
                            Console.WriteLine("4. Delete Patient");
                            Console.WriteLine("0. Back to Main Menu");
                            Console.Write("Enter your choic: ");

                            int Pchoose = Convert.ToInt32(Console.ReadLine());
                            switch (Pchoose)
                            {

                                case 1:
                                    Console.WriteLine("Add New Patient");
                                    break;

                                case 2:
                                    Console.WriteLine("Display All Patients");
                                    break;

                                case 3:
                                    Console.WriteLine("Update Patient Phone");
                                    break;

                                case 4:
                                    Console.WriteLine("Delete Patient");
                                    break;

                                case 0:
                                    Console.WriteLine("Exit");
                                    break;

                                default:
                                    Console.WriteLine("Invalid choice!");
                                    break;
                            }
                        }






                   

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Appointment Managment Menue");
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


            //───────────────────────── Region 3 ─────────────────────────────────────────────── 


            int option = Convert.ToInt32(Console.ReadLine());
            bool stop = false;
            while (stop == false)
            {

                switch (option)
                {

              


                }


            }







        }
    }
}
