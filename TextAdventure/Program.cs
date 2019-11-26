using System;
using System.Threading;

namespace TextAdventure
{


    class Program
    {
        static void Main(string[] args)
        {

           

            Intro();




            static void Intro()
            {


                Console.WriteLine("Welcome to Jay's Pizza Palace.");
                Console.WriteLine("We are currently looking to fill 3 positions we have open.");
                Console.WriteLine("Those positions are dish washer,");
                Console.WriteLine("pizza delivery driver, and cook.");
                Thread.Sleep(7000);
                Console.Clear();

                Console.WriteLine("Because of the need to quickly fill these positions");
                Console.WriteLine("there is no experience required.");
                Thread.Sleep(5000);
                Console.Clear();

                Console.WriteLine("You will need to take our brief quiz to see which position");
                Console.WriteLine("Best suits your skills.");
                Thread.Sleep(5000);
                Console.Clear();

                Console.WriteLine("Press 'Enter' to proceed to quiz");
                Console.ReadLine();
                Console.Clear();

               
                

                Quiz();



            }

            static void Quiz()
            {


                Question1();



                static void Question1()
                {
                    int answer1;

                    Console.WriteLine("Question 1");
                    Console.WriteLine("In 5 weeks John has saved $3.50. ");
                    Console.WriteLine("What have his average weekly savings been?");
                    Console.WriteLine("1. 0.70.");
                    Console.WriteLine("2. 0.50.");
                    Console.WriteLine("3. 0.65.");
                    Console.Write("Answer: ");
                    answer1 = Convert.ToInt32(Console.ReadLine().ToLower());
                    Console.Clear();

                    if (answer1 == 1)
                    {
                        Question2();
                    }
                    Console.WriteLine("Sorry that is incorrect.");
                    Console.ReadLine();
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.Clear();
                    firstJob();


                }


                static void Question2()
                {
                    int answer2;

                    Console.WriteLine("Question 2");
                    Console.WriteLine("What is the pizza capitol of the World?");
                    Console.WriteLine("1. Old Forge, Pennsylvania.");
                    Console.WriteLine("2. Little Italy, New York.");
                    Console.WriteLine("3. Sicily, Italy.");
                    Console.Write("Answer: ");
                    answer2 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (answer2 == 1)
                    {
                        Question3();

                    }
                    Console.WriteLine("Sorry that is incorrect");
                    Console.ReadLine();
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.Clear();
                    secondJob();



                }


                static void Question3()
                {

                    int answer3;

                    Console.WriteLine("Question 3");
                    Console.WriteLine("How many slice of Pizza are in a large?");
                    Console.WriteLine("1. 8 Slices.");
                    Console.WriteLine("2. 12 Slices.");
                    Console.WriteLine("3. 10 Slices.");
                    Console.Write("Answer: ");
                    answer3 = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (answer3 == 3)
                    {
                        thirdJob();

                    }
                    Console.WriteLine("Sorry that is incorrect");
                    Console.ReadLine();
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.Clear();
                    secondJob();




                }


                static void firstJob()
                {


                    Console.WriteLine($"Congratulations! You've been hired");
                    Console.WriteLine("to fill our dishwasher position.");

                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("As the dish washer you are responsible for making");
                    Console.WriteLine("sure all of the dishes are clean, as well as taking the trash out.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    string choice;
                    Console.WriteLine("It's your first day on the job, and you are almost done washing the dishes when");
                    Console.WriteLine("the busboy brings another load of dishes, dropping food all over you.");
                    Console.WriteLine("What do you do?");
                    Console.WriteLine("1. Spray him with water.");
                    Console.WriteLine("2. Say nothing, and wash the dishes.");
                    Console.Write("Choice: ");
                    choice = Console.ReadLine().ToLower();
                    Console.Clear();



                    switch (choice)
                    {

                        case "1":
                        case "Spray him":              
                            {
                                Console.WriteLine("You spray him with water and as you do he ducks down");
                                Console.WriteLine("causing the water to shoot over him spraying your boss in the face.");
                                Console.WriteLine("The boss is enraged with anger!");
                                Console.WriteLine("He screams, You're fired!");
                                Thread.Sleep(5000);
                                Console.Clear();
                                gameOver();
                                break;
                            }

                        case "2":
                        case "Say nothing":
                            {

                                Console.WriteLine("You say nothing and continue to wash the dishes");
                                Console.WriteLine("The boss is impressed with your work ethic and decides to give you a promotion.");
                                Console.WriteLine("Press 'Enter' to continue.");
                                Console.ReadLine();
                                Console.Clear();

                                secondJob();
                                break;


                            }

                    }








                }


                static void secondJob()
                {


                    Console.WriteLine("Congratulations! You've been hired");
                    Console.WriteLine("to fill our delivery driver position!");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();


                    Console.WriteLine("As the posistion of deivery driver it is up to you to make");
                    Console.WriteLine("sure that all deliveries are done in a timely manner.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("It's your first day on the delivery job.");
                    Console.WriteLine("You have 6 deliveries to make and the place is busy so you need to hurry");
                    Console.WriteLine("back so you can make more deliveries.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("As you are leaving out on your first delivery run, you get a phone call");
                    Console.WriteLine("from your best friend, who is broke down on the side of the road.");
                    Console.WriteLine("He asks for you to stop and help jump his car off as you are on your way");
                    Console.WriteLine("to make your deliveries.");
                    Console.WriteLine("Press 'Enter' to continue.");
                    Console.ReadLine();
                    Console.Clear();

                    string choice;
                    Console.WriteLine("What do you do?");
                    Console.WriteLine("1. Tell him your sorry but you are working and you can't help him.");
                    Console.WriteLine("2. Help him on your way to make deliveries.");
                    Console.Write("Choice: ");
                    choice = Console.ReadLine().ToLower();
                    Console.Clear();

                    switch (choice)
                    {
                        case "1":
                            {
                                Console.WriteLine("You decide not to help him and a stranger stops to help him.");
                                Console.WriteLine("You make all of your deliveries in record time!");
                                Console.WriteLine("You get back to the Pizza Palace and the boss is impressed");
                                Console.WriteLine("He is so impressed that he gives you a promotion!");
                                Console.WriteLine("Press 'Enter' to continue.");
                                Console.ReadLine();
                                Console.Clear();

                                thirdJob();
                                break;


                            }

                        case "2":
                            {
                                Console.WriteLine("You decide to stop and help him as it is on the way to");
                                Console.WriteLine("Your first delivery.");
                                Console.WriteLine("As you stop to help him a stranger pulls up and robs you both");
                                Console.WriteLine("stealing away with the car and all of the pizzas!");
                                Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("You call the boss to explain all that happened.");
                                Console.WriteLine("He is enraged that you lost all of the pizzas and fires you on the spot.");

                                Console.ReadLine();
                                Console.Clear();

                                gameOver();
                                break;

                                




                            }
                    }




                }

                static void thirdJob()
                {
                    Console.WriteLine("Congratulations! You've been hired");
                    Console.WriteLine("to fill our cook position!");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("As the position of cook it is up to you to make sure that all of the pizzas are");
                    Console.WriteLine("cooked in a timely manner.");
                    Console.ReadLine();
                    Console.Clear();

                    Console.WriteLine("It's your first day on the job and you are responsible for making sure all of");
                    Console.WriteLine("the pizzas that are out on the buffet are fresh at all times");
                    Console.ReadLine();
                    Console.Clear();


                    string choice;
                    Console.WriteLine("You have just finished making all of the pizzas when someone comes to the front");
                    Console.WriteLine("and requests that you make them another cheese pizza, insulting you as they ask");
                    Console.WriteLine("What do you do?");
                    Console.WriteLine("1. Tell the customer it would be your pleasure to make them another pizza.");
                    Console.WriteLine("2. Politley ask the customer to leave the store.");
                    Console.WriteLine("3. Tell your boss of the situation.");
                    Console.Write("Choice: ");
                    choice = Console.ReadLine().ToLower();
                    Console.Clear();

                    switch (choice)
                    {
                        case "1":
                            {
                                
                                Console.WriteLine("You make another cheese pizza, only to forget that you put");
                                Console.WriteLine("the pizza in the oven");
                                Console.WriteLine("This in turn causes the kitchen to set on fire.");
                                Console.WriteLine("You call the for help and the busboy comes to help you");
                                Console.WriteLine("The fire is put out and the boss comes to see what all the commotion is about");
                                Console.WriteLine("Press 'Enter' to continue.");
                                Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("Angry the boss asks which one of you is held responsible.");
                                Console.WriteLine("What do you tell him?");
                                Console.WriteLine("1. Tell the boss it is all your fault.");
                                Console.WriteLine("2. Blame the busboy, (since he doesn't like you anyway.)");
                                Console.Write("Choice: ");
                                choice = Console.ReadLine().ToLower();
                                Console.Clear();

                                switch (choice)
                                {
                                    case "1":

                                        {
                                            Console.WriteLine("The boss is angry but yet glad that you are honest.");
                                            Console.WriteLine("The boss is so impressed that he gives you yet another");
                                            Console.WriteLine("big promotion, this time you are the new shift manager!");
                                            Console.WriteLine("Press 'Enter' to continue.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            youWin();
                                            break;
                                        }

                                    case "2":
                                        {

                                            Console.WriteLine("You blame the busboy, getting him fired!");
                                            Console.WriteLine("The busboy is furious!");
                                            Console.WriteLine("He waits for you to get off of work, sneaking behind you");
                                            Console.WriteLine("he knocks you to the ground, putting you in the hospital.");
                                            Console.WriteLine("You are so injured that you cannot make it to work the next day.");
                                            Console.WriteLine("Press 'Enter' to continue.");
                                            Console.ReadLine();
                                            Console.Clear();

                                            Console.WriteLine("The boss does not believe your excuse and he fires you!");

                                            gameOver();
                                            break;



                                        }


                                }




                            }
                            break;

                        case "2":
                            {

                                Console.WriteLine("You politley ask the person to leave the store");
                                Console.WriteLine("and they do not want to comply. They begin to throw pizzas");
                                Console.WriteLine("across the room and even on you.");
                                Console.WriteLine("Your boss sees the whole incident and throws the customer out of the store.");
                                Console.WriteLine("Impressed by your tenacity the boss decides to give you a promotion!");
                                Console.WriteLine("You are the new shift manager!.");
                                Console.ReadLine();
                                Console.Clear();

                                youWin();
                                break;


                            }
                        case "3":
                            {
                             


                                Console.WriteLine("You immediatley run to tell your boss the whole situation");
                                Console.WriteLine("and he is furious!");
                                Console.WriteLine("He screams at you for not doing your job and making them another pizza!");
                                Console.WriteLine("He tells you that you need to go back to washing dishes!");
                                Console.WriteLine("You've been demoted!");
                                Console.ReadLine();
                                Console.Clear();

                                firstJob();
                                break;



                            }
                    }

                   

                }

                static void gameOver()
                {

                    
                    Console.WriteLine("You've been fired!");
                    Console.WriteLine("Press 'Enter' to try again.");
                    Console.ReadLine();
                    Console.Clear();
                   
                    

                    Intro();



                }

                static void youWin()
                {

                    Console.WriteLine("Congrats you have made it to shift manager of Jay's Pizza Palace.");
                    Console.WriteLine("Press 'Enter' to play again.");
                    Console.ReadLine();
                    Console.Clear();

                    Intro();




                }

















            }
        }
    }
}