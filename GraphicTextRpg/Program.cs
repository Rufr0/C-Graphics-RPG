using System;

namespace GraphicTextRpg
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string location = "Menu";string responce;string ocupation;string past_location="none";



			switch (location)
			{

			case "Menu":
				System.Console.WriteLine ("Welcome to a quick adventure game I made");
				System.Console.WriteLine ("Press RETURN to start");
				System.Console.ReadLine ();
				goto case "Character Setup";


			case "Character Setup":
				System.Console.Write ("Name your player:");
				string Player_Name = System.Console.ReadLine ();
				System.Console.WriteLine ("Well hello " + Player_Name + " I haven\'t met you before, what do you do?\n[a]\tTrader\n[b]\tHunter\n[c]\tFarmer");
				responce = System.Console.ReadLine ();
				if (responce == "a")
					ocupation = "traider";
				else if (responce == "b")
					ocupation = "hunter";
				else if (responce == "c")
					ocupation = "farmer";
				else
					ocupation = "traider";

				System.Console.WriteLine("You are now in main game, try typing things and figuring out what to do!\nonly letters please\nalso use commands like up, rather than get up\n\n:D\n");
				goto case "register responce";

			
			case "register responce":
				responce = System.Console.ReadLine ().ToLower ();

				if (responce == "help") {
					System.Console.WriteLine ("Try to figure it out on your own");
					goto case "register responce";
				}

				if (responce == "hi" || responce == "hello") {
					System.Console.WriteLine ("<From the darkness> Hello...");
					goto case "register responce";
				}

				if (responce == "who are you") {
					System.Console.WriteLine ("<From the darkness> I am a monster...so people say...");
					goto case "register responce";
				}

				if (responce == "up") {
					System.Console.WriteLine ("Chains rattle at your feet...Can i find a key?");
					goto case "register responce";
				}

				if (responce == "look") {
					System.Console.WriteLine ("<From the darkness> Are you looking for a key...here");
					goto case "register responce";
				}


				break;



			}





		}
	}
}
