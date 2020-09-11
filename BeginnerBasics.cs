///*
using System;
///*
namespace Egregious{
  /*public*/ class MainStrt{
    /*public*/ static void Main(string[] args){
      Console.WriteLine("Does this?");
      ComeOn.Beginner howard = new ComeOn.Beginner();
      // Beginner howard = new Beginner();
      howard.testyThing("Hey now");
      // Beginner.testyThing("Hey now");
    }
  }
}

namespace ComeOn{
  class Beginner{
    public void testyThing(string thingy){
      Console.WriteLine($"Well, {thingy}?\nIt seems there are {thingy.Length} characters; well that's {thingy.Remove(1)}.\nNow get A LOAD OF THIS!\n{/*ReverseMe(thingy)*/thingy}");
    }
    private string ReverseMe(string s){

      return "";
    }
  }
}
//*/