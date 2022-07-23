using BehavioralPatterns.ChainOfResponsibility;
using BehavioralPatterns.Command;
using BehavioralPatterns.Iterator;
using BehavioralPatterns.Observer;
using BehavioralPatterns.Strategy;
using Utility;

// I T E R A T O R

// return new object with desirable IEnumerator interface stored iside same class, dont thik it's good solution
ConsoleDecoration.AddDecoration("Iterator Inside Collection example",
                                () => IteratorUseExamples.IteratorInsideCollectionRun());

// creates new object of another class that implements IEnumerator interface, better solution imho
ConsoleDecoration.AddDecoration("Iterator Outside Collection example",
                                () => IteratorUseExamples.IteratorOutsideCollectionRun());

// O B S E R V E R

// implementation using events
ConsoleDecoration.AddDecoration("Observer Using Events example",
                                () => ObserverUseExamples.ObserverUsingEventsRun());

// C O M M A N D

ConsoleDecoration.AddDecoration("Command With History example",
                                () => CommandUseExamples.CommandWithHistoryRun());

// C H A I N   O F   R E S P O N S I B I L I T Y

ConsoleDecoration.AddDecoration("Simple Chain of Reponsibility example",
                                () => CoRUseExamples.SimpleCoRExampleRun());

// S T R A T E G Y

ConsoleDecoration.AddDecoration("Simple Strategy example",
                                () => StrategyUseExample.SimpleStrategyExampleRun());