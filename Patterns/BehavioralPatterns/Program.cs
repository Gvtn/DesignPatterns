using BehavioralPatterns.Command;
using BehavioralPatterns.Iterator;
using BehavioralPatterns.Observer;

// I T E R A T O R

// return new object with desirable IEnumerator interface stored iside same class, dont thik it's good solution
IteratorUseExamples.IteratorInsideCollectionRun();

// creates new object of another class that implements IEnumerator interface, better solution imho
IteratorUseExamples.IteratorOutsideCollectionRun();

// O B S E R V E R

// implementation using events
ObserverUseExamples.ObserverUsingEventsRun();

// C O M M A N D

CommandUseExamples.CommandWithHistoryRun();