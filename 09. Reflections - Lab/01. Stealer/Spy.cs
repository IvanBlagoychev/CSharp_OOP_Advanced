using System;
using System.CodeDom;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] classFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();

        Object classInstance = Activator.CreateInstance(classType, new object[] { });
        sb.AppendLine($"Class under investigation: {investigatedClass}");

        foreach (FieldInfo field in classFields.Where(f => requestedFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }
        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        FieldInfo[] clasFields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        MethodInfo[] classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        MethodInfo[] classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        var sb = new StringBuilder();

        foreach (FieldInfo field in clasFields)
            sb.AppendLine($"{field.Name} must be private!");

        foreach (MethodInfo method in classNonPublicMethods.Where(m => m.Name.StartsWith("get")))
            sb.AppendLine($"{method.Name} have to be public!");

        foreach (MethodInfo method in classPublicMethods.Where(m => m.Name.StartsWith("set")))
            sb.AppendLine($"{method.Name} have to be private!");
        return sb.ToString().Trim();
    }

    public string RevealPrivateMethods(string investiagtedClass)
    {
        Type classType = Type.GetType(investiagtedClass);
        MethodInfo[] nonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        var sb = new StringBuilder();
        sb.AppendLine($"All Private Methods of Class: {investiagtedClass}");
        sb.AppendLine($"Base Class: {classType.BaseType.Name}");

        foreach (MethodInfo method in nonPublicMethods)
        {
            sb.AppendLine(method.Name);
        }
        return sb.ToString().Trim();
    }

    public string CollectGettersAndSetters(string investigatedClass)
    {
        Type classType = Type.GetType(investigatedClass);
        MethodInfo[] methods =
            classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
        var sb = new StringBuilder();

        foreach (MethodInfo method in methods.Where(x => x.Name.StartsWith("get")))
            sb.AppendLine($"{method.Name} will return {method.ReturnType.FullName}");
        foreach (MethodInfo method in methods.Where(x => x.Name.StartsWith("set")))
            sb.AppendLine($"{method.Name} will set field of {method.GetParameters().First().ParameterType}");

        return sb.ToString().Trim();
    }
}