using StructuralPatterns.Adapter;
using StructuralPatterns.Bridge;
using StructuralPatterns.Composite;
using StructuralPatterns.Facade;
using StructuralPatterns.Flyweight;
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

// F L Y W E I G H T

ConsoleDecoration.AddDecoration("Flyweight Factory example",
                                () => FlyweightUseExamples.FlyweightWIthFactoryRun());