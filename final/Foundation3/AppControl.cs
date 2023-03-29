namespace EventPlanning
{
    public class AppControl
    {
        public void Run()
        {

            LectureEvent lecture = new LectureEvent(
                "The Science of AI",
                "Learn about the latest advancements in artificial intelligence",
                new DateTime(2023, 4, 15, 14, 0, 0),
                
                new Address("123 Main St", "San Francisco", "CA", "94105"),
                "Dr. Jane Doe",
                50
            );

            ReceptionEvent reception = new ReceptionEvent(
                "Annual Charity Gala",
                "Join us for an evening of food, drinks, and entertainment to support local charities",
                new DateTime(2023, 5, 20, 18, 0, 0),
                
                new Address("456 Broadway", "New York", "NY", "10013"),
                "rsvp@example.com"
            );

            OutdoorGatheringEvent outdoorGathering = new OutdoorGatheringEvent(
                "Summer Music Festival",
                "Enjoy live music from a variety of artists",
                new DateTime(2023, 7, 8, 12, 0, 0),
            
                new Address("789 Oak St", "Seattle", "WA", "98101"),
                "Sunny with a high of 75 degrees"
            );


            string option = "";
            while(option != "4")
            {
                Console.WriteLine("Option available: ");
                Console.WriteLine("1. Lecture Event");
                Console.WriteLine("2. Reception Event");
                Console.WriteLine("3. Outdoor Event");
                Console.WriteLine("4. Quit");

                try
                {
                    option = Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    Console.ReadKey();
                    continue;
                }

                switch (option)
                {
                    case "1":
                        while(option != "4")
                        {
                            Console.WriteLine("Display Option: ");
                            Console.WriteLine("1. Standard Details");
                            Console.WriteLine("2. Full Details");
                            Console.WriteLine("3. Short description");
                            Console.WriteLine("4. Quit");
                            try
                            {
                                option = Console.ReadLine();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                                Console.ReadKey();
                                continue;
                            }

                            switch(option)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine(lecture.GetStandardDetails());
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine(lecture.GetFullDetails());
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine(lecture.GetShortDescription());
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again.");
                                    Console.ReadKey();
                                    continue;
                            }

                        }
                        break;
                    case "2":
                        while(option != "4")
                        {
                            Console.WriteLine("Display Option: ");
                            Console.WriteLine("1. Standard Details");
                            Console.WriteLine("2. Full Details");
                            Console.WriteLine("3. Short description");
                            Console.WriteLine("4. Quit");
                            try
                            {
                                option = Console.ReadLine();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                                Console.ReadKey();
                                continue;
                            }

                            switch(option)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine(reception.GetStandardDetails());
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine(reception.GetFullDetails());
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine(reception.GetShortDescription());
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again.");
                                    Console.ReadKey();
                                    continue;
                            }

                        }
                        break;
                    case "3":
                        while(option != "4")
                        {
                            Console.WriteLine("Display Option: ");
                            Console.WriteLine("1. Standard Details");
                            Console.WriteLine("2. Full Details");
                            Console.WriteLine("3. Short description");
                            Console.WriteLine("4. Quit");
                            try
                            {
                                option = Console.ReadLine();
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid input. Please enter a number.");
                                Console.ReadKey();
                                continue;
                            }

                            switch(option)
                            {
                                case "1":
                                    Console.Clear();
                                    Console.WriteLine(outdoorGathering.GetStandardDetails());
                                    Console.ReadKey();
                                    break;
                                case "2":
                                    Console.Clear();
                                    Console.WriteLine(outdoorGathering.GetFullDetails());
                                    Console.ReadKey();
                                    break;
                                case "3":
                                    Console.Clear();
                                    Console.WriteLine(outdoorGathering.GetShortDescription());
                                    Console.ReadKey();
                                    break;
                                case "4":
                                    break;
                                default:
                                    Console.WriteLine("Invalid option. Please try again.");
                                    Console.ReadKey();
                                    continue;
                            }

                        }
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        Console.ReadKey();
                        continue;
                }
            }   
        }
    }
}