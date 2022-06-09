using StructuralPatterns.Adapter;
using Utility;

// P R O X Y

ProxyStartExamples.ProxyToExternalSystemRun();

ConsoleDecoration.AddDecoration("Proxy with lazy loading example",
                                () => ProxyStartExamples.LazyLoadingProxyRun());

// A D A P T E R

ConsoleDecoration.AddDecoration("Adapter Of Object example",
                                () => AdapterUseExamples.AdapterOfObjectRun()); 

