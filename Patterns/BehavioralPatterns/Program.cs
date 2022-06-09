using BehavioralPatterns.Command;
using BehavioralPatterns.Iterator;
using BehavioralPatterns.Observer;
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
