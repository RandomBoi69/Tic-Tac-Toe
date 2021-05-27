



using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace main
{

    public class Program
    {
     public static void Main(string[] args)
        {
            bool turn_ = true;
            List<string> p = new List<string> { "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]", "[ ]"};
            Console.WriteLine("Tic Tac Toe\nType numbers to choose!\n[1][2][3]\n[4][5][6]\n[7][8][9]\n\nPress any key to continue");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
            while (true)
            {
            	String turn = "";
            	if (turn_) {
            	    turn = Console.ReadLine();
            	}
            	else if (!turn_) {
            		int i = new Random().Next(1, 2);
            		int q = new Random().Next(1, 2);
            		turn = Convert.ToString(new Random().Next(0, 10));
            		if (turn == turn) {
            			turn = Convert.ToString(new Random().Next(0, 10));
            		}
            	   	if (p[3] == "[X]" && p[6] == "[X]") {
            	   		if (q == 1) {
            	   			turn = "1";
            	   		}
            	   		else {
            	   			turn = Convert.ToString(new Random().Next(0, 10));
            	   		}
            		}
            		if (p[0] == "[X]" && p[3] == "[X]") {
            			if (q == 1) {
            				turn = "7";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0, 10));
            			}
            		}
            		if (p[1] == "[X]" && p[4] == "[X]") {
            			if (q == 1) {
            				turn = "8";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0, 10));
            			}
            		}
            		if (p[7] == "[X]" && p[4] == "[X]") {
            			if (q == 1) {
            				turn = "2";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[2] == "[X]" && p[5] == "[X]") {
            			if (q == 1) {
            				turn = "9";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0, 10));
            			}
            		}
            		if (p[5] == "[X]" && p[8] == "[X]") {
            			if (q == 1) {
            				turn = "3";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[0] == "[X]" && p[1] == "[X]") {
            			if (q == 1) {
            				turn = "3";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[1] == "[X]" && p[2] == "[X]") {
            			if (q == 1) {
            				turn = "1";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[0] == "[X]" && p[2] == "[X]") {
            			if (q == 1) {
            				turn = "2";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[3] == "[X]" && p[4] == "[X]") {
            			if (q == 1) {
            				turn = "4";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[4] == "[X]" && p[5] == "[X]") {
            			if (q == 1) {
            				turn = "4";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[3] == "[X]" && p[5] == "[X]") {
            			if (q == 1) {
            				turn = "5";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[6] == "[X]" && p[7] == "[X]") {
            			if (q == 1) {
            				turn = "9";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[7] == "[X]" && p[8] == "[X]") {
            			if (q == 1) {
            				turn = "7";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		if (p[6] == "[X]" && p[8] == "[X]") {
            			if (q == 1) {
            				turn = "6";
            			}
            			else {
            				turn = Convert.ToString(new Random().Next(0,10));
            			}
            		}
            		
            		if (p[0] == "[O]" && p[3] == "[O]") {
            		    turn = "7";
            		}
            		if (p[3] == "[O]" && p[6] == "[O]") {
            		    turn = "1";
            		}
            		if (p[1] == "[O]" && p[4] == "[O]") {
            		    turn = "8";
            		}
            		if (p[4] == "[O]" && p[7] == "[O]") {
            		    turn = "2";
            		}
            		if (p[2] == "[O]" && p[5] == "[O]") {
            		    turn = "9";
            		}
            		if (p[5] == "[O]" && p[8] == "[O]") {
            		    turn = "3";
            		}
            		if (p[0] == "[O]" && p[1] == "[O]") {
            		    turn = "3";
            		}
            		if (p[1] == "[O]" && p[2] == "[O]") {
            		    turn = "1";
            		}
            		if (p[3] == "[O]" && p[4] == "[O]") {
            		    turn = "6";
            		}
            		if (p[4] == "[O]" && p[5] == "[O]") {
            		    turn = "4";
            		}
            		if (p[6] == "[O]" && p[7] == "[O]") {
            		    turn = "9";
            		}
            		if (p[7] == "[O]" && p[8] == "[O]") {
            		    turn = "7";
            		}
            		if (p[0] == "[O]" && p[6] == "[O]") {
            		    turn = "4";
            		}
            		if (p[1] == "[O]" && p[7] == "[O]") {
            		    turn = "5";
            		}
            		if (p[2] == "[O]" && p[8] == "[O]") {
            		    turn = "6";
            		}
            		if (p[0] == "[O]" && p[8] == "[O]") {
            		    turn = "5";
            		}
            		if (p[2] == "[O]" && p[6] == "[O]") {
            		    turn = "5";
            		}
                	if (turn != "1" || turn != "2" || turn != "3" || turn != "4" || turn != "5" || turn != "6" || turn != "7" || turn != "8" || turn != "9") {
                		turn = Convert.ToString(new Random().Next(1, 9));
            	}
                }
                if (p[0] == "[ ]")
                {
                    if (turn == "1")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[0] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[0] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[1] == "[ ]")
                {
                    if (turn == "2")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[1] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[1] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[2] == "[ ]")
                {
                    if (turn == "3")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[2] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[2] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[3] == "[ ]")
                {
                    if (turn == "4")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[3] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[3] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "\n" + p[3] + p[4] + p[5] + "\n" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[4] == "[ ]")
                {
                    if (turn == "5")
                    {if (turn_)
                        {
                            Console.Clear();
                            p[4] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[4] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[5] == "[ ]")
                {
                    if (turn == "6")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[5] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[5] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[6] == "[ ]")
                {
                    if (turn == "7")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[6] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[6] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[7] == "[ ]")
                {
                    if (turn == "8")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[7] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[7] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                    }
                }
                if (p[8] == "[ ]")
                {
                    if (turn == "9")
                    {
                        if (turn_)
                        {
                            Console.Clear();
                            p[8] = "[X]";
                            turn_ = false;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                        else if (!turn_)
                        {
                            Console.Clear();
                            p[8] = "[O]";
                            turn_ = true;
                            Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                        }
                    }
                }if(turn != "1" && turn != "2" && turn != "3" && turn != "4" && turn != "5" && turn != "6" && turn != "7" && turn != "8" && turn != "9")
                {
                    Console.Clear();
                    Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                }

                if(p[0] == p[1] && p[1] == p[2] && p[2] != "[ ]"|| p[3] == p[4] && p[4] == p[5] && p[5] != "[ ]" || p[6] == p[7] && p[7] == p[8] && p[8] != "[ ]" ||
                    p[0] == p[3] && p[3] == p[6] && p[6] != "[ ]" || p[1] == p[4] && p[4] == p[7] && p[7] != "[ ]" || p[2] == p[5] && p[5] == p[8] && p[8] != "[ ]" ||
                    p[0] == p[4] && p[4] == p[8] && p[8] != "[ ]" || p[2] == p[4] && p[4] == p[6] && p[2] != "[ ]")
                {
                    if (turn_)
                        Console.WriteLine("O is the winner!");
                    else
                        Console.WriteLine("X is the winner!");
                    Console.ReadLine();
                    Console.Clear();
                    p[0] = "[ ]"; p[1] = "[ ]"; p[2] = "[ ]"; p[3] = "[ ]"; p[4] = "[ ]"; p[5] = "[ ]"; p[6] = "[ ]"; p[7] = "[ ]"; p[8] = "[ ]";
                    turn_ = true;
                    Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                }
                else if(p[0] != "[ ]" && p[1] != "[ ]" && p[2] != "[ ]" && p[3] != "[ ]" && p[4] != "[ ]" && p[5] != "[ ]" && p[6] != "[ ]" && p[7] != "[ ]" && p[8] != "[ ]")
                {
                    Console.WriteLine("Draw!");
                    Console.ReadLine();
                    Console.Clear();
                    p[0] = "[ ]"; p[1] = "[ ]"; p[2] = "[ ]"; p[3] = "[ ]"; p[4] = "[ ]"; p[5] = "[ ]"; p[6] = "[ ]"; p[7] = "[ ]"; p[8] = "[ ]";
                    turn_ = true;
                    Console.WriteLine(p[0] + p[1] + p[2] + "
" + p[3] + p[4] + p[5] + "
" + p[6] + p[7] + p[8]);
                }
            }
           
        }
    }
}
