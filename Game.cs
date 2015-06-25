using System.Collections.Generic;
using System.Linq;
public class Game
{
	private List<int> rolls = new List<int>();
	
	public int Score()
	{
		int totalScore = 0;
		for (int i = 0; i < rolls.Count; i+=2) {
			if (rolls.Count == 1)
				totalScore += rolls[i];
			if (rolls[i] == 10){
				totalScore+= rolls.Sum() + rolls[i+1] + rolls[i+2];	
			}
			if (rolls[i] + rolls[i+1] == 10){
				totalScore+= rolls[i-1] + rolls[i];
			}	
		}
		
		return totalScore;
		
	}
	
	public void Roll(int pins)
	{
		rolls.Add(pins);
		if (rolls.Count % 2 == 1 && pins == 10){
			Roll(0);
		}
	}
} 