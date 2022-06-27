using CreationalPatterns.Builder;
using CreationalPatterns.FactoryMethod;
using CreationalPatterns.Prototype;
using CreationalPatterns.Singleton;
using Utility;

// F A C T O R Y   M E T H O D

ConsoleDecoration.AddDecoration("Factory Method Based On Abstraction example",
                                () => FactoryMethodUseExamples.FactoryMethodBasedOnAbstractionRun());

FactoryMethodUseExamples.FactoryMethod2();

// B U I L D E R

ConsoleDecoration.AddDecoration("Builder With Director example",
                                () => BuilderUseExamples.BuilderWithDirectorRun());

ConsoleDecoration.AddDecoration("Builder Fluent Syntax example",
                                () => BuilderUseExamples.BuilderFluentSyntaxRun());

BuilderUseExamples.BuilderFluentAnotherOneRun();

// S I N G L E T O N

ConsoleDecoration.AddDecoration("Thread Unsafe Singleton example",
                                () => SingletonUseExamples.ThreadUnsafeSingletonExampleRun());

ConsoleDecoration.AddDecoration("Thread Safe Singleton example",
                                () => SingletonUseExamples.ThreadSafeSingletonExampleRun());

// P R O T O T Y P E

ConsoleDecoration.AddDecoration("Shallow vs Deep Copy Prototype example",
                                () => PrototypeUseExamples.ShallowVsDeepCopyRun());