using System.Runtime.InteropServices;

Console.WriteLine("Welcome to Arundel Castle!");
Console.WriteLine();

Console.Write("Share your name chosen one");
Console.WriteLine();
string name = Console.ReadLine();

Console.WriteLine("Welcome... " + name + ".");
Console.WriteLine();

Console.WriteLine("The Queen has been found. The beloved ruler of Arundel is dead. ");
Console.WriteLine("She jumped from the highest tower of the castle. Word begins to spread throughout...  ");
Console.WriteLine();
Console.WriteLine("Choose who you are in that story: ");
Console.WriteLine();
Console.WriteLine("1. The King");
Console.WriteLine("2. The Maid");
Console.WriteLine("3. The Priest");
Console.WriteLine("4. The Cook Lady");


string choice;

    while (true)
{
    Console.WriteLine();
    Console.WriteLine("Choose your character 1 - 4. ");
    choice = Console.ReadLine();

    if (choice == "1" || choice == "2" ||
        choice == "3" || choice == "4") break;
    Console.WriteLine("Wrong. Please enter a correct number and try again. ");
}

if (choice == "1")
{
    Console.WriteLine();
    Console.WriteLine(name + ", you are the King.");
    Console.WriteLine("Your wife, the Queen, is gone.");
    Console.WriteLine();
    Console.WriteLine("You hear a rumour that dark magic is involed but is it true?");
    Console.WriteLine();



    string q1, q2, q3, q4;
    int good = 0;
    int evil = 0;

    // QUESTION 1 K 

    Console.WriteLine("What is your first thought? ");
    Console.WriteLine();
    Console.WriteLine("1. Something is lost and will never return. ");
    Console.WriteLine("2. You start by blaming yourself. You know it all started with you. ");
    Console.WriteLine("3. Henry VIII was more direct, you got away with it. ");
    Console.WriteLine("4. Well, she was always a bit emotional wasn't she?");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q1 = Console.ReadLine();

        if (q1 == "1" || q1 == "2"
            || q1 == "3" || q1 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4. ");
    }

    // QUESTION 2 K 

    Console.WriteLine(" You find out that your affair has been exposed, and the Queen, knowing that the fruit of this affair lives under her roof,");
    Console.WriteLine(" has decided to use it in a ritual to gain possession of dark powers.");
    Console.WriteLine();
    Console.WriteLine("What do you chose?");
    Console.WriteLine();
    Console.WriteLine("1. This sounds like a crazy story. Things may not have been the best between you two, but the Queen never had evil in her heart.");
    Console.WriteLine("2. Order to check on the child. If there's even a grain of truth to this story, we must make sure heir to the throne is safe. ");
    Console.WriteLine("3. You've been waiting for this moment. Summon the guards and have the army prepared. If she wants a fight, she'll get one.");
    Console.WriteLine("4. Phatetic, yet impressive. Perhaps if she'd shown this much initiative earlier, things between you wouldn't have been so difficult.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q2 = Console.ReadLine();

        if (q2 == "1" || q2 == "2"
        || q2 == "3" || q2 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 3 K 

    Console.WriteLine("It turns out that while you were lost in thought, an entire story was unfolding right beneath your feet. ");
    Console.WriteLine("The Queen's servant kidnapped the heir to the throne and attempted to complete the ritual.");
    Console.WriteLine();
    Console.WriteLine("What do you do?");
    Console.WriteLine();
    Console.WriteLine("1. Wybor 1");
    Console.WriteLine("2. wYBOR 2 ");
    Console.WriteLine("3. Wybor 3");
    Console.WriteLine("4. Wybor 4");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q3 = Console.ReadLine();

        if (q3 == "1" || q3 == "2"
            || q3 == "3" || q3 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 4 K

    Console.WriteLine("Chose your item: ");
    Console.WriteLine();
    Console.WriteLine("1. Prayer beads. It should protect agaisnt evil maigc. ");
    Console.WriteLine("2. Flowers. She used to love roses. ");
    Console.WriteLine("3. Sword. It's time to smash something. ");
    Console.WriteLine("4. Pastries. Eating feelings is always an option. ");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q4 = Console.ReadLine();

        if (q4 == "1" || q4 == "2"
            || q4 == "3" || q4 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // ENDINGS K
    
    Console.WriteLine();
    Console.WriteLine(" Your story ends here my King...");

    good = 0;
    evil = 0;

    string[] answers = { q1, q2, q3, q4 };

    foreach (string answer in answers)
    {
        if (answer == "1" || answer == "2")
        {
            good++;
        }
        else
        {
            evil++;
        }
    }

    Console.WriteLine("Good points: " + good);
    Console.WriteLine("Evil points: " + evil);

    if (good == 4)
        Console.WriteLine(" The story ends well. The servant is stopped, and the young heir to the throne is sent somewhere safe. " +
            "Now it's time to mourn and give the Queen a proper burial. " +
            "This is what is best for the survival od the monarchy.");

    else if (good == 3)
    {
        Console.WriteLine("Your decisions have only made things more complicated up until now. The child is safe" +
            "The servant has been stopped and awaits trail. It's a shame things had to end in tragedy, but at least another one has been prevented.");
    }

    else if (good == 2)
    {

        Console.WriteLine(" The worst has happened. The ritual is complete. Demons are ravaging your kingdom and slaughtering your subjects." +
            "It seems the winged figure standing atop the tower is waiting for you to join them and prove that your words were not an empty threats.");
    }

    else
    {
        Console.WriteLine("The Queen's servant has fullfilled her role. The Queen had returned, and you have been captured. They have no idea they're dealing with yet...");
    }

    Console.WriteLine();
    Console.WriteLine("Thank you for that journay " + name + " until next time!");

}

else if (choice == "2")
{
    Console.WriteLine(name + ", you are the Queen's faithful Maid.");
    Console.WriteLine("Your beloved empress, the Queen, is dead... but that was all part of the plan, wasn't it? Now everything is in your hand " + name + ". There's only one final piece of the puzzle left to complete... the heir to the throne!");


    string q1, q2, q3, q4;
    int good = 0;
    int evil = 0;

    // QUESTION 1 M 

    Console.WriteLine("You've managed to steal the child. Now it's just short journey to the kitchen, just as the Queen instructed. Let's hope the oven is ready.");
    Console.WriteLine();
    Console.WriteLine("What is your first thought? ");
    Console.WriteLine();
    Console.WriteLine("1. but is this really the only solution? The Queen promised to help you with your case in return, but is it really worth it? ");
    Console.WriteLine("2. You try to find the courage, but deep down,you know that what you're about to do is wrong. You have to stop this. ");
    Console.WriteLine("3. You're so close. Just few more moves and you'll throw the child into the oven. The ritual will be complete, and the grateful Queen will grant your every wish. ");
    Console.WriteLine("4. Great wishes require great sacrifices. You're sacrificing a life -  not your own, but hey, it's still a sacrifice, isn't it?");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q1 = Console.ReadLine();

        if (q1 == "1" || q1 == "2"
            || q1 == "3" || q1 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4. ");
    }

    // QUESTION 2 M 

    Console.WriteLine(" The cook is already in the kitchen when you arrive. The moment she sees you with the child, she realises what you're planning and steps forward to stop you.");
    Console.WriteLine();
    Console.WriteLine("What do you chose?");
    Console.WriteLine();
    Console.WriteLine("1. Beg for help and show remorse.");
    Console.WriteLine("2. Apologise to her for what she is about to witness. ");
    Console.WriteLine("3. Kill the cook and throw the child into the oven.");
    Console.WriteLine("4. Offer a deal. If she helps, you the Queen will surely welcome her into her inner circle.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q2 = Console.ReadLine();

        if (q2 == "1" || q2 == "2"
        || q2 == "3" || q2 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 3 M 

    Console.WriteLine(" You have to believe that the ritual is real, but are you truly certain it is? ");
    Console.WriteLine();
    Console.WriteLine("What's your thoughts?");
    Console.WriteLine();
    Console.WriteLine("1. This is all heresy. Magic doesn't exist.");
    Console.WriteLine("2. If evil exists, then good must exist too. There has to be another way! ");
    Console.WriteLine("3. You have nothing to lose in life. What harm could come from taking a chance?");
    Console.WriteLine("4. Only the weak have second thoughts. Let's do the work.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q3 = Console.ReadLine();

        if (q3 == "1" || q3 == "2"
            || q3 == "3" || q3 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 4 M

    Console.WriteLine("Chose your item: ");
    Console.WriteLine();
    Console.WriteLine("1. Magic ring, protects the faithfull. ");
    Console.WriteLine("2. A necklace belonging to your lost beloved. ");
    Console.WriteLine("3. An herb that gives courage. ");
    Console.WriteLine("4. Lightweight boots that let you run faster. ");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q4 = Console.ReadLine();

        if (q4 == "1" || q4 == "2"
            || q4 == "3" || q4 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // ENDINGS
    Console.WriteLine();
    Console.WriteLine(" Your story ends here poor Maid...");

    good = 0;
    evil = 0;

    string[] answers = { q1, q2, q3, q4 };

    foreach (string answer in answers)
    {
        if (answer == "1" || answer == "2")
        {
            good++;
        }
        else
        {
            evil++;
        }
    }

    Console.WriteLine("Good points: " + good);
    Console.WriteLine("Evil points: " + evil);

    if (good == 4)
        Console.WriteLine(" You hand the child over to the cook, beg for her help in escaping, and plead for forgiveness. May the Almighty have mercy on your soul.");

    else if (good == 3)
    {
        Console.WriteLine("The Queen's offer seemed like the only and easiest solution, but you simply cannot fulfil her request. There are other options in this world, and you intend to find them.");
    }

    else if (good == 2)
    {

        Console.WriteLine(" Your intensions are on thing, but the world has other plans. The cook is faster and strikes you with an axe. You fall to the ground, tears welling in your eyes. Perhpas at last you'll be reunited with your beloved.");
    }

    else
    {
        Console.WriteLine("The cook's screams and the slam of the oven door are the last things you remember before the Queen appears before you. Her demonic wings brush against your shoulders, and her eyes eagerly await the wish you are about to make");
    }

    Console.WriteLine();
    Console.WriteLine("Thank you for that journay " + name + " until next time!");
}

else if (choice == "3")
{
    Console.WriteLine(name + ", you are the Priest.");
    Console.WriteLine("The King's wife is dead. You feel a strange tingling sensation throughout your body. The scent of ginger fills the chapel. So it's true... she has begun the ritual.");


    string q1, q2, q3, q4;
    int good = 0;
    int evil = 0;

    // QUESTION 1 P 

    Console.WriteLine("What is your first thought? ");
    Console.WriteLine();
    Console.WriteLine("1. This is a tragedy. She must have eventually found out about the child. The kindgdom needs your support now. ");
    Console.WriteLine("2. The King should have listened to your advice when he had the chance. Now it's time to ensure the child's safety. ");
    Console.WriteLine("3. This was to be expected. Her Majesty was never the strongest of souls. ");
    Console.WriteLine("4. Perhaps it's time to consider changing parishes.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q1 = Console.ReadLine();

        if (q1 == "1" || q1 == "2"
            || q1 == "3" || q1 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4. ");
    }

    // QUESTION 2 P

    Console.WriteLine(" Intuition is part of your profession, and yours tells you to ivestigate the kichen. You arrive just in time to find a distraught cook. Not far from her, near the oven, lies the Queen's maid, face down on the floor, with an axe embedded in her shoulder." +
        " At least the crying infant, wrapped in a blanket, is sitll alive.");
    Console.WriteLine();
    Console.WriteLine("What do you do?");
    Console.WriteLine();
    Console.WriteLine("1. Calm down the cook down and assure her that she's no longer in danger.");
    Console.WriteLine("2. Approach the bundle. This child's story isn't over yet. The baby cannot be left here. ");
    Console.WriteLine("3. This is all some kind of farce. Dark magic is nonsens, and these people are clearly delusional.");
    Console.WriteLine("4. Wait for the guards to arrive. The freshly baked cookies catch your attention.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q2 = Console.ReadLine();

        if (q2 == "1" || q2 == "2"
        || q2 == "3" || q2 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 3 P

    Console.WriteLine(" The King summons you to his chambers. It seems he already knows everything. He asks for your advice on what should be done with the child.");
    Console.WriteLine();
    Console.WriteLine("What do you say?");
    Console.WriteLine();
    Console.WriteLine("1. Advise him to protect the cook from being executed and send the child far away from the kingdom.");
    Console.WriteLine("2. Offer to take care of the child, in exchange for a suitable payment.");
    Console.WriteLine("3. Shouldn't he listen to you earlier? He has the blood of both the Queen and the maid on his hands!");
    Console.WriteLine("4. You've had quite enough of this place. It's all becoming too much for your nerved. Besides, the cookies were salty.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q3 = Console.ReadLine();

        if (q3 == "1" || q3 == "2"
            || q3 == "3" || q3 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 4 P 

    Console.WriteLine("Chose your item: ");
    Console.WriteLine();
    Console.WriteLine("1. Candle with an eternal flame. ");
    Console.WriteLine("2. Prayer beads. It should protect agaisnt evil maigc. ");
    Console.WriteLine("3. A golden Bible. Gold always help. ");
    Console.WriteLine("4. A compass. ");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q4 = Console.ReadLine();

        if (q4 == "1" || q4 == "2"
            || q4 == "3" || q4 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // ENDINGS P 
    Console.WriteLine();
    Console.WriteLine(" Your story ends here dear Priest...");

    good = 0;
    evil = 0;

    string[] answers = { q1, q2, q3, q4 };

    foreach (string answer in answers)
    {
        if (answer == "1" || answer == "2")
        {
            good++;
        }
        else
        {
            evil++;
        }
    }

    Console.WriteLine("Good points: " + good);
    Console.WriteLine("Evil points: " + evil);

    if (good == 4)
        Console.WriteLine(" The King has decided that the child must leave the castle. You conduct the Queen's funeral, after which you plan to move elsewhere and continue your service.");

    else if (good == 3)
    {
        Console.WriteLine("Faith works miracles. The King has kept his wits about him and, this time, chosen the path you advised him to take.");
    }

    else if (good == 2)
    {

        Console.WriteLine("Aboslute power answers to no one. The child was not allowed to live. Problem solved... for now. ");
    }

    else
    {
        Console.WriteLine("The King has ordered your exile. Your actions have drive him into a rage, and you have only a few hours to pack your belongings.");
    }

    Console.WriteLine();
    Console.WriteLine("Thank you for that journay " + name + " until next time!");

}



else if (choice == "4")
{
    Console.WriteLine(name + ", you are the Cook Lady.");
    Console.WriteLine("It was an ordinary day, much like any other. You were alone in the kitchen, when suddenly you heard the rumours. This can't end well.");

    string q1, q2, q3, q4;
    int good = 0;
    int evil = 0;

    // QUESTION 1 KL

   
    Console.WriteLine("What is your first thought? ");
    Console.WriteLine();
    Console.WriteLine("1. You knew something was wrong. The Queen hadn't eaten anything in days. ");
    Console.WriteLine("2. Perhaps you should speak to the priest. If people are driven to such extremes, they must need someone to turn to. ");
    Console.WriteLine("3. Does this mean you need to prepare fewer dishes or more? ");
    Console.WriteLine("4. You can only hope this has nothing to do with your cooking.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q1 = Console.ReadLine();

        if (q1 == "1" || q1 == "2"
            || q1 == "3" || q1 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4. ");
    }

    // QUESTION 2 KL

    Console.WriteLine("Suddenly, a girl rushes into the kitchen, clutching a bundle. You recognise her as one of the Queen's maids. What on earth is she planning to do with the oven?");
    Console.WriteLine();
    Console.WriteLine("What's next?");
    Console.WriteLine();
    Console.WriteLine("1. Instict kicks in faster than anything else. You grab the meat cleaver.");
    Console.WriteLine("2. Something is clearly wrong. You stay alert, watching her every move. ");
    Console.WriteLine("3. It's non of your business. You shouldn't get involved.");
    Console.WriteLine("4. At that very moment, you realise you've added salt to the biscuits instead of sugar. Opsie daisy...");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q2 = Console.ReadLine();

        if (q2 == "1" || q2 == "2"
        || q2 == "3" || q2 == "4")
        {
            break;
        }
        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 3 KL

    Console.WriteLine("Everything happened so quickly. Now you stand over the maid, who lies on the floor with a meat cleaver embedded in her shoulder. Beside her, a baby cries. Your hands are trembling. ");
    Console.WriteLine();
    Console.WriteLine("What's next?");
    Console.WriteLine();
    Console.WriteLine("1. The most important thing is that you've save an innocent child.");
    Console.WriteLine("2. The priest will understand the situation and defend you. You are not a murder. ");
    Console.WriteLine("3. It couldn't have been you... could it? Was it really you? They'll hang you!");
    Console.WriteLine("4. There's no time to waste. It's time to run.");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q3 = Console.ReadLine();

        if (q3 == "1" || q3 == "2"
            || q3 == "3" || q3 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // QUESTION 4 KL

    Console.WriteLine("Chose your item: ");
    Console.WriteLine();
    Console.WriteLine("1. A french frying pan. ");
    Console.WriteLine("2. A little pot of rose tea. ");
    Console.WriteLine("3. A meat cleaver. ");
    Console.WriteLine("4. A filleting sword. ");

    while (true)
    {
        Console.WriteLine("Choose the answer: ");
        q4 = Console.ReadLine();

        if (q4 == "1" || q4 == "2"
            || q4 == "3" || q4 == "4")
        {
            break;
        }

        Console.WriteLine("Invalid choice. Enter one number from 1 to 4.");
    }

    // ENDINGS KL

    Console.WriteLine();
    Console.WriteLine(" Your story ends here cook...");

    good = 0;
    evil = 0;

    string[] answers = { q1, q2, q3, q4 };

    foreach (string answer in answers)
    {
        if (answer == "1" || answer == "2")
        {
            good++;
        }
        else
        {
            evil++;
        }
    }

    Console.WriteLine("Good points: " + good);
    Console.WriteLine("Evil points: " + evil);

    if (good == 4)
        Console.WriteLine(" The priest arrives. He calms you down and assures you that you're safe now. The King will surely listen to him.);

    else if (good == 3)
    {
        Console.WriteLine("After a few days, you're released. Not everyone knows how to cook, and the kingdom needs to be fed. Besides, you did save the King's bastard or something?");
    }

    else if (good == 2)
    {

        Console.WriteLine(" Actions and words cannot save everyone. To ensure the truth never comes to light, you must face the gallows. No one believed your promises to keep silent.");
    }

    else
    {
        Console.WriteLine("The guards have arrived. You're placed under arrest. Murder is one thing, but now the truth about the salty biscuits has come to light too...");
    }

    Console.WriteLine();
    Console.WriteLine("Thank you for that journay " + name + " until next time!");



}

else
{
    Console.WriteLine(" Wrong choice. Please try again. ");
}


Console.WriteLine();
Console.WriteLine("Press any key to finish. ");
Console.ReadKey();