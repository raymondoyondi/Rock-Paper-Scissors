using System;

class MainClass {
 
	static int rock = 0;
	static int paper = 1;
	static int scissors = 2;
	
	static int playerScore = 0;
	static int enemyScore = 0;
	
	static int playerSign = 0;
	static int enemySign = 0;
	
	static void Main() {
        
        Console.WriteLine("Welcome to the game Rock Paper Scissors");
        Console.WriteLine("Enter numbers in the input field and separate them with Enter. The explanation is below:");
        Console.WriteLine(" 0 = rock,\n 1 = paper,\n 2 = scissors.\n");
        Console.WriteLine("Have fun playing!\n");
        
		int round = 1;
		while(round < 6){
			Console.WriteLine("Round " + round);
			playerSign = Int32.Parse(Console.ReadLine());	
       
        Random r = new Random();
		enemySign = r.Next(0,3);
		
		CompareSigns();

		TranslatePlayerSign();
		TranslateEnemySign();
          
		round++;
		
		ShowScore();
      
		Console.WriteLine();
		}
		Console.WriteLine("Game over");
		CheckFinalScore();
    }
    
    public static void CompareSigns(){
		if(playerSign == paper && enemySign == rock){
			playerScore++;
			Console.WriteLine("You win");
		}

		else if(playerSign == rock && enemySign == scissors){
			playerScore++;
			Console.WriteLine("You win");
		}

		else if(playerSign == scissors && enemySign == paper){
			playerScore++;
			Console.WriteLine("You win");
		}

		else if(playerSign == enemySign){
			Console.WriteLine("Draw");
		}
		
		else{
			enemyScore++;
			Console.WriteLine("You lost");
		}	
    }
    
    public static void TranslatePlayerSign(){
      if (playerSign == 0){
		  Console.WriteLine("Your choice is rock");
		} 
	  
	  else if(playerSign == 1){
		  Console.WriteLine("Your choice is paper");
		}
	  
	  else if(playerSign == 2){
		  Console.WriteLine("Your choice is scissors");
		}
	  
	  else{
		  Console.WriteLine("Your selection is not appropriate");
		}
    }
    
    public static void TranslateEnemySign(){
		if (enemySign == 0){
			Console.WriteLine("The enemy's choice is rock");
		}
		
		else if(enemySign == 1){
			Console.WriteLine("The enemy's choice is paper");
		}
		
		else if(enemySign == 2){
			Console.WriteLine("The enemy's choice is scissors");
		}
		
		else{
			Console.WriteLine("Enemy selection is not suitable");
		}
    }
    
    public static void ShowScore(){
       Console.WriteLine("Player's current score: " + playerScore + " vs" + " Enemy: " + enemyScore);
    }
  
    public static void CheckFinalScore(){
        if(playerScore > enemyScore){
			Console.WriteLine("Congrats, You Won the Match!");
			Console.WriteLine("Player's final result: " + playerScore + " vs" + " Enemy: " +enemyScore);			
		}
	
		else if(playerScore == enemyScore){
			Console.WriteLine("Draw");
			Console.WriteLine("Player's final result: " + playerScore + " vs" + " Enemy: " +enemyScore);		
		}
		
		else{
			Console.WriteLine("Well, you lost. Try again!");
			Console.WriteLine("Player's final result: " + playerScore + " vs" + " Enemy: " +enemyScore);			
		}
	}
}
