using System;
using System.Collections.Generic;
using System.Linq;

namespace VotingApp
{
    internal class Program
    {
        /// <summary>
        /// Voting Uygulaması
        /// Uygulama çalıştığında pre-defined olarak belirlenen kategoriler oylamaya sunulmak üzere listelenmelidir.
        /// Yalnızca sisteme kayıtlı olan kullanıcılar oy verebilir. Oylama sırasında öncelikle kullanıcının username'i istenmelidir.
        /// Eğer sistemde kayıtlı değilse kayıt olmasına imkan sağlanmalı ve kaldığı yerden oylamaya devam edebilmelidir.
        /// Kategoriler isteğe bağlı olarak belirlenebilir. Bazı Örnek Kategoriler: Film Kategorileri Tech Stack Kategorileri Spor Kategorileri
        /// Son olarak uygulama sonlandırılırken, Voting sonuçları hem rakamsal hem de yüzdesel olarak gösterilmelidir.
        /// </summary>
        /// <param name="args"></param>

        static string userName = "";
        static string password = "";

        static Dictionary<string, string> loginInformations = new Dictionary<string, string>();
        static Dictionary<string, int> filmNames = new Dictionary<string, int>();
        static Dictionary<string, int> programmingLanguages = new Dictionary<string, int>();
        static Dictionary<string, int> sportNames = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            PreDefinedValues();

            Console.WriteLine("<---------- Welcome to the Voting App ---------->\n");
            Console.WriteLine("In which category would you like to vote?\n");
            Console.WriteLine("1) Film");
            Console.WriteLine("2) Tech Stack");
            Console.WriteLine("3) Sports\n");

            int categorySelection = int.Parse(Console.ReadLine());

            if (categorySelection == 1 || categorySelection == 2 || categorySelection == 3)
            {
                bool validSelection = false;
                int loginOrSignUpSelection = 0;

                while (!validSelection)
                {
                    Console.WriteLine("\nFirst, you need to log in");
                    Console.WriteLine("1) Log in");
                    Console.WriteLine("2) Sign up\n");
                    loginOrSignUpSelection = int.Parse(Console.ReadLine());

                    if (loginOrSignUpSelection == 1 || loginOrSignUpSelection == 2)
                    {
                        validSelection = true;
                    }
                    else
                    {
                        Console.Write("Please enter a valid value: ");
                    }
                }

                while (true)
                {
                    if (loginOrSignUpSelection == 1)
                    {
                        if (!UserLogIn())
                        {
                            validSelection = false;
                            while (!validSelection)
                            {
                                Console.WriteLine("\nWhat would you like to do?");
                                Console.WriteLine("1) Log in");
                                Console.WriteLine("2) Sign up\n");
                                loginOrSignUpSelection = int.Parse(Console.ReadLine());

                                if (loginOrSignUpSelection == 1 || loginOrSignUpSelection == 2)
                                {
                                    validSelection = true;
                                }
                                else
                                {
                                    Console.Write("Please enter a valid value: ");
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (loginOrSignUpSelection == 2)
                    {
                        UserSignUp();
                        break;
                    }
                }
            }

            switch (categorySelection)
            {
                case 1:
                    FilmCategory();
                    break;
                case 2:
                    TechCategory();
                    break;
                case 3:
                    SportCategory();
                    break;
            }
        }

        static void PreDefinedValues()
        {
            loginInformations.Add("ahmetyagiz", "123456");

            filmNames.Add("1", 65); // The Shawshank Redemption(1994)
            filmNames.Add("2", 40); // The Godfather(1972)
            filmNames.Add("3", 39); // The Dark Knight
            filmNames.Add("4", 38); // Schindler's List
            filmNames.Add("5", 45); // The Lord of the Rings: The Return of the King(2003)

            programmingLanguages.Add("1", 55); // Pyhton
            programmingLanguages.Add("2", 42); // C#
            programmingLanguages.Add("3", 45); // Javascript
            programmingLanguages.Add("4", 44); // Java
            programmingLanguages.Add("5", 40); // C++

            sportNames.Add("1", 55); // Football
            sportNames.Add("2", 30); // Voleyball
            sportNames.Add("3", 45); // Basketball
            sportNames.Add("4", 20); // Tennis
        }

        static bool UserLogIn()
        {
            while (true)
            {
                Console.Write("\nUsername: ");
                userName = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                if (loginInformations.ContainsKey(userName) && loginInformations[userName] == password)
                {
                    Console.WriteLine("Signed in successfully.");
                    return true;
                }
                else
                {
                    Console.WriteLine("The username or password you entered is incorrect.");
                    Console.WriteLine("1) Try again");
                    Console.WriteLine("2) Sign up\n");

                    int selection = int.Parse(Console.ReadLine());

                    if (selection == 1)
                    {
                        continue;
                    }
                    else if (selection == 2)
                    {
                        UserSignUp();
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection. Exiting...");
                        return false;
                    }
                }
            }
        }

        static void UserSignUp()
        {
            while (true)
            {
                Console.Write("\nUsername: ");
                userName = Console.ReadLine();

                if (loginInformations.ContainsKey(userName))
                {
                    Console.WriteLine("This username is already in use.\nPlease enter a different username.");
                }
                else
                {
                    break;
                }
            }

            while (true)
            {
                Console.Write("Password: ");
                password = Console.ReadLine();

                Console.Write("Confirm password: ");
                string confirmPassword = Console.ReadLine();

                if (password == confirmPassword)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Passwords do not match.\nPlease enter your password again.");
                }
            }

            loginInformations.Add(userName, password);
            Console.WriteLine("User registered successfully.");
        }

        static void FilmCategory()
        {
            Console.WriteLine("\n<---------- Film Category ---------->\n");
            Console.WriteLine("What is the best movie of all time?\n");
            Console.WriteLine("1) The Shawshank Redemption (1994)");
            Console.WriteLine("2) The Godfather (1972)");
            Console.WriteLine("3) The Dark Knight");
            Console.WriteLine("4) Schindler's List");
            Console.WriteLine("5) The Lord of the Rings: The Return of the King (2003)");

            string filmInput = Console.ReadLine();

            while (true)
            {
                if (filmNames.ContainsKey(filmInput))
                {
                    filmNames[filmInput]++;
                    break;
                }
                else
                {
                    Console.Write("Please enter a valid value: ");
                    filmInput = Console.ReadLine();
                }
            }

            Console.WriteLine("\nVoting Results:");

            foreach (KeyValuePair<string, int> entry in filmNames)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} votes");
            }

            int totalVotes = filmNames.Values.Sum();
            Console.WriteLine($"Total votes: {totalVotes}");

            Console.WriteLine("\nVoting Results (%):");

            foreach (KeyValuePair<string, int> entry in filmNames)
            {
                float percentage = (float)entry.Value / totalVotes * 100;
                Console.WriteLine($"{entry.Key}: {percentage}%");
            }
        }

        static void TechCategory()
        {
            Console.WriteLine("\n<---------- Tech Category ---------->\n");
            Console.WriteLine("What is your favorite programming language?\n");
            Console.WriteLine("1) Pyhton");
            Console.WriteLine("2) C#");
            Console.WriteLine("3) Javascript");
            Console.WriteLine("4) Java");
            Console.WriteLine("5) C++\n");

            string programmingInput = Console.ReadLine();

            while (true)
            {
                if (programmingLanguages.ContainsKey(programmingInput))
                {
                    programmingLanguages[programmingInput]++;
                    break;
                }
                else
                {
                    Console.Write("Please enter a valid value: ");
                    programmingInput = Console.ReadLine();
                }
            }

            Console.WriteLine("\nVoting Results:");

            foreach (KeyValuePair<string, int> entry in programmingLanguages)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} votes");
            }

            int totalVotes = programmingLanguages.Values.Sum();
            Console.WriteLine($"Total votes: {totalVotes}");

            Console.WriteLine("\nVoting Results (%):");

            foreach (KeyValuePair<string, int> entry in programmingLanguages)
            {
                float percentage = (float)entry.Value / totalVotes * 100;
                Console.WriteLine($"{entry.Key}: {percentage}%");
            }
        }

        static void SportCategory()
        {
            Console.WriteLine("\n<---------- Sports Category ---------->\n");
            Console.WriteLine("What is your favorite sport?\n");
            Console.WriteLine("1) Football");
            Console.WriteLine("2) Voleyball");
            Console.WriteLine("3) Basketball");
            Console.WriteLine("4) Tennis\n");

            string sportInput = Console.ReadLine();

            while (true)
            {
                if (sportNames.ContainsKey(sportInput))
                {
                    sportNames[sportInput]++;
                    break;
                }
                else
                {
                    Console.Write("Please enter a valid value: ");
                    sportInput = Console.ReadLine();
                }
            }

            Console.WriteLine("\nVoting Results:");

            foreach (KeyValuePair<string, int> entry in sportNames)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value} votes");
            }

            int totalVotes = sportNames.Values.Sum();
            Console.WriteLine($"Total votes: {totalVotes}");

            Console.WriteLine("\nVoting Results (%):");

            foreach (KeyValuePair<string, int> entry in sportNames)
            {
                float percentage = (float)entry.Value / totalVotes * 100;
                Console.WriteLine($"{entry.Key}: {percentage}%");
            }
        }
    }
}