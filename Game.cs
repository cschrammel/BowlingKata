using System.Collections.Generic;
using System.Linq;

public class Game
{
	private List<int> _pins = new List<int>();	
	
	public void Roll(int pins)
	{
		if (_pins.Count >= 2 && _pins[_pins.Count() - 1] + _pins[_pins.Count() - 2] == 10)
			_pins[_pins.Count() - 1] = _pins[_pins.Count() - 1] + pins; 
	
		_pins.Add(pins); 
	}
	
	public int Score()
	{
	  	return _pins.Sum();
	}
} 