using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;
using StructuralPatterns.Composite;
using StructuralPatterns.Decorator;
using StructuralPatterns.Facade;
using Utility;

// P R O X Y

ProxyStartExamples.ProxyToExternalSystemRun();

ConsoleDecoration.AddDecoration("Proxy with lazy loading example",
                                () => ProxyStartExamples.LazyLoadingProxyRun());

// A D A P T E R

ConsoleDecoration.AddDecoration("Adapter Of Object example",
                                () => AdapterUseExamples.AdapterOfObjectRun());

// F A C A D E

ConsoleDecoration.AddDecoration("Facade With Two Subsystems example",
                                () => FacadeUseExamples.FacadeWithTwoSubsystemsRun());

// B R I D G E

ConsoleDecoration.AddDecoration("Bridge Name Formatting example",
                                () => BridgeUseExamples.NameFormatterRun());

// C O M P O S I T E

ConsoleDecoration.AddDecoration("Composite Mail example",
                                () => CompositeUseExamples.CompositeMailRun());

// D E C O R A T O R

ConsoleDecoration.AddDecoration("Decorator notifier example",
                                () => DecoratorUseExamples.DecoratorNotifierRun());