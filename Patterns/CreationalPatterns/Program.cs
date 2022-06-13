using CreationalPatterns.Builder;
using CreationalPatterns.FactoryMethod;
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