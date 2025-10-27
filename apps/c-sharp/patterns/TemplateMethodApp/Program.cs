using System;
using System.Collections.Generic;

/*
 * IReportTemplate implements a template method defining the skeleton of an algorithm
 */
abstract class IReportTemplate
{
    private void RenderTitle(string title)
    {
        Console.WriteLine(title);
    }

    private void RenderHeadings(List<string> headings)
    {
        foreach (var heading in headings)
        {
            Console.Write(heading + "\t");
        }
        Console.WriteLine();
    }

    private void RenderRows(List<List<string>> rows)
    {
        foreach (var row in rows)
        {
            foreach (var cell in row)
            {
                Console.Write(cell + "\t");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    private void RenderFooter(string title)
    {
        Console.WriteLine(title);
    }

    protected abstract string GetTitle();
    protected abstract List<string> GetHeadings();
    protected abstract List<List<string>> GetRows();
    protected abstract string GetFooter();

    public void TemplateMethod()
    {
        RenderTitle(GetTitle());
        RenderHeadings(GetHeadings());
        RenderRows(GetRows());
        RenderFooter(GetFooter());
    }
}

/*
 * CompanyReport implements the primitive operations to carry out specific steps
 * of the algorithm, there may be many Concrete classes, each implementing
 * the full set of the required operation
 */
class CompanyReport : IReportTemplate
{
    protected override string GetTitle()
    {
        return "Scoppa Software Solutions, LLC";
    }

    protected override List<string> GetHeadings()
    {
        return new List<string> { "SKU", "PRICE" };
    }

    protected override List<List<string>> GetRows()
    {
        return new List<List<string>>
        {
            new List<string> { "a01d", "$12.99" },
            new List<string> { "a7cd", "$15.99" },
            new List<string> { "a9cb", "$18.99" }
        };
    }

    protected override string GetFooter()
    {
        return "All rights reserved";
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        IReportTemplate tm = new CompanyReport();
        tm.TemplateMethod();
    }

}