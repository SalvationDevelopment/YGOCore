using System;
using System.Runtime.Serialization;

namespace YGOCore.Game
{
    [DataContract]
	public interface IGameConfig
	{
        [DataMember(Order=0)]
		int LfList { get; set; }
        [DataMember(Order=1)]
		int Rule { get; set; }
        [DataMember(Order=2)]
		int Mode { get; set; }
        [DataMember(Order=3)]
		bool EnablePriority { get; set; }
        [DataMember(Order=4)]
		bool NoCheckDeck { get; set; }
        [DataMember(Order=5)]
		bool NoShuffleDeck { get; set; }
        [DataMember(Order=6)]
		int StartLp { get; set; }
        [DataMember(Order=7)]
		int StartHand { get; set; }
        [DataMember(Order=8)]
		int DrawCount { get; set; }
        [DataMember(Order=9)]
		int GameTimer { get; set; }
        [DataMember(Order=10)]
		string Name { get; set; }
		void Load(String info);
	}
}

