#pragma checksum "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f410ea434e94c5b37fb291c2d673cdf25509f6e1"
// <auto-generated/>
#pragma warning disable 1591
namespace blazorserver01.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using blazorserver01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pzx98720\blazorserver01\_Imports.razor"
using blazorserver01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Game of Life</h1> \r\n<hr>\r\n");
#nullable restore
#line 5 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
  
    //only first time (init pattern)
    if(currentCount==0) {
        e.put_pattern(6,6,"pentadecathlon");
    }
    int svgh = e.total_of_rows()*9+2;
    int svgw = e.total_of_cols()*9+2;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "\r\n");
            __builder.OpenElement(2, "svg");
            __builder.AddAttribute(3, "height", 
#nullable restore
#line 14 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
              svgh

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(4, "width", 
#nullable restore
#line 14 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                            svgw

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.AddMarkupContent(6, "<defs>\r\n        <filter id=\"myBlur\" x=\"0\" y=\"0\">\r\n            <feGaussianBlur in=\"SourceGraphic\" stdDeviation=\"3\"></feGaussianBlur>\r\n        </filter>\r\n    </defs>\r\n");
#nullable restore
#line 20 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
     for(var i=0; i<@e.total_of_rows(); i++) {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
         for(var j=0; j<@e.total_of_cols(); j++) {
            int cy = (i*9+4+1);
            int cx = (j*9+4+1);
            int idx = i;
            int jdx = j;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
             if(e.biounit(i,j)!=null) {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "                ");
            __builder.OpenElement(8, "circle");
            __builder.AddAttribute(9, "cx", 
#nullable restore
#line 27 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                             cx

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "cy", 
#nullable restore
#line 27 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                      cy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(11, "r", "4");
            __builder.AddAttribute(12, "fill", "#90FA90");
            __builder.AddAttribute(13, "filter", "url(#myBlur)");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                                ()=>CellClick(idx, jdx)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 29 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
            }
            else {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                ");
            __builder.OpenElement(17, "circle");
            __builder.AddAttribute(18, "cx", 
#nullable restore
#line 31 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                             cx

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(19, "cy", 
#nullable restore
#line 31 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                      cy

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "r", "4");
            __builder.AddAttribute(21, "fill", "#909090");
            __builder.AddAttribute(22, "filter", "url(#myBlur)");
            __builder.AddAttribute(23, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                                ()=>CellClick(idx, jdx)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
#nullable restore
#line 33 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n<hr>\r\n");
            __builder.OpenElement(26, "p");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "radio");
            __builder.AddAttribute(30, "name", "myradiobtn");
            __builder.AddAttribute(31, "checked", 
#nullable restore
#line 40 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                   theRadio.Equals("step")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(32, "value", "step");
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                   ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(34, " Step by step\r\n    ");
            __builder.OpenElement(35, "input");
            __builder.AddAttribute(36, "type", "radio");
            __builder.AddAttribute(37, "name", "myradiobtn");
            __builder.AddAttribute(38, "checked", 
#nullable restore
#line 44 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                   theRadio.Equals("many")

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "value", "many");
            __builder.AddAttribute(40, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                   ClickRadio

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, " Several steps\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "style", "display:" + " " + (
#nullable restore
#line 49 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                       theRadio.Equals("many")?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.AddMarkupContent(46, "<h5>Cycles specifications</h5>\r\n    Number of Cycles:\r\n    ");
            __builder.OpenElement(47, "input");
            __builder.AddAttribute(48, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                  cyclesPerTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cyclesPerTime = __value, cyclesPerTime));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(50, " (internal value: ");
            __builder.AddContent(51, 
#nullable restore
#line 52 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                                      cyclesPerTime

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(52, ")\r\n    <hr>\r\n\r\n    ");
            __builder.OpenElement(53, "div");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "form");
            __builder.AddAttribute(56, "action", "_blank");
            __builder.AddMarkupContent(57, "\r\n        ");
            __builder.AddMarkupContent(58, "<label for=\"selectedCycle\">Select a Cycle:</label>\r\n        ");
            __builder.OpenElement(59, "select");
            __builder.AddAttribute(60, "id", "selectedCycle");
            __builder.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 58 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                       selectedCycle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedCycle = __value, selectedCycle));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "first");
            __builder.AddContent(66, "First");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "second");
            __builder.AddContent(70, "Second");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "third");
            __builder.AddContent(74, "Third");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "fourth");
            __builder.AddContent(78, "Fourth");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n\r\n        ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "style", "display:" + " " + (
#nullable restore
#line 65 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                               selectedCycle.Equals("first")
        || selectedCycle.Equals("second")
        || selectedCycle.Equals("third")
        || selectedCycle.Equals("fourth") ?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(83, "\r\n        (You selected ");
            __builder.AddContent(84, 
#nullable restore
#line 69 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                       selectedCycle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(85, " cycle)\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        <hr>\r\n        <input type=\"submit\" value=\"Submit\">\r\n        <hr>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n\r\n");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "btn btn-primary");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                          o => this.isOpen = !this.isOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(93, "\r\n");
            __builder.AddContent(94, 
#nullable restore
#line 79 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
  this.isOpen ? "Add Pattern..." : "Add Pattern (-)"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n");
#nullable restore
#line 81 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
 if(!isOpen){
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(97, 
#nullable restore
#line 82 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
     PatternsList[0]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 82 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                    ;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(98, "    <hr>\r\n");
            __builder.AddContent(99, 
#nullable restore
#line 84 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
     PatternsList[1]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 84 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                    ;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(100, "    <hr>\r\n");
            __builder.AddContent(101, 
#nullable restore
#line 86 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
     PatternsList[2]

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 86 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                    ;

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(102, "    <hr>\r\n");
#nullable restore
#line 88 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(103, "\r\n");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "style", "display:" + " " + (
#nullable restore
#line 90 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                       isOpen.Equals(false)?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(106, "\r\n    ");
            __builder.OpenElement(107, "form");
            __builder.AddAttribute(108, "method", "post");
            __builder.AddAttribute(109, "action", "AddPattern");
            __builder.AddMarkupContent(110, "\r\n        ");
            __builder.AddMarkupContent(111, "<label for=\"selectedPattern\">Select Pattern Type:</label>\r\n        ");
            __builder.OpenElement(112, "select");
            __builder.AddAttribute(113, "id", "selectedPattern");
            __builder.AddAttribute(114, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 93 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                       selectedPattern

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedPattern = __value, selectedPattern));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.OpenElement(117, "option");
            __builder.AddAttribute(118, "value", "aforall");
            __builder.AddContent(119, "A for All");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n            ");
            __builder.OpenElement(121, "option");
            __builder.AddAttribute(122, "value", "bipole");
            __builder.AddContent(123, "Bipole");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n            ");
            __builder.OpenElement(125, "option");
            __builder.AddAttribute(126, "value", "pentadecathlon");
            __builder.AddContent(127, "Pentadecathlon");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n    row\r\n    ");
            __builder.OpenElement(131, "input");
            __builder.AddAttribute(132, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                  rowNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(133, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => rowNumber = __value, rowNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(134, " (internal value: ");
            __builder.AddContent(135, 
#nullable restore
#line 100 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                                  rowNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(136, ")\r\n    column\r\n    ");
            __builder.OpenElement(137, "input");
            __builder.AddAttribute(138, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 102 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                  columnNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(139, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => columnNumber = __value, columnNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddContent(140, " (internal value: ");
            __builder.AddContent(141, 
#nullable restore
#line 102 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                                     columnNumber

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(142, ")\r\n    ");
            __builder.OpenElement(143, "button");
            __builder.AddAttribute(144, "class", "btn btn-success");
            __builder.AddAttribute(145, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                              AddPattern

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(146, " Add");
            __builder.CloseElement();
            __builder.AddMarkupContent(147, "\r\n    \r\n    <hr>\r\n    ");
            __builder.OpenElement(148, "button");
            __builder.AddAttribute(149, "class", "btn btn-primary");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 106 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                              o => this.isCollapsed = !this.isCollapsed

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(151, "\r\n");
            __builder.AddContent(152, 
#nullable restore
#line 107 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
  this.isCollapsed ? "Add Cells..." : "Add Cells (-)"

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(153, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n\r\n");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "style", "display:" + " " + (
#nullable restore
#line 110 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                       isCollapsed.Equals(false)?"":"none"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(157, "\r\n    \r\n    ");
            __builder.OpenElement(158, "textarea");
            __builder.AddAttribute(159, "rows", "");
            __builder.AddAttribute(160, "cols", "");
            __builder.AddAttribute(161, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 112 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                      cells

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(162, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cells = __value, cells));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(163, "\r\n    ");
            __builder.OpenElement(164, "input");
            __builder.AddAttribute(165, "type", "submit");
            __builder.AddAttribute(166, "class", "btn btn-primary");
            __builder.AddAttribute(167, "value", "Add");
            __builder.AddAttribute(168, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                                                       NewCell

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(169, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(170, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n\r\n<hr>\r\n");
            __builder.OpenElement(172, "button");
            __builder.AddAttribute(173, "class", "btn btn-primary");
            __builder.AddAttribute(174, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(175, " Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n");
            __builder.AddMarkupContent(177, "<a class=\"btn btn-primary\" href=\"https://en.wikipedia.org/wiki/Conway%27s_Game_of_Life\" \\ target=\"_blank\">\r\n    Look for Patterns in Wikipedia\r\n </a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
       
    private string selectedCycle = "" ;
    private string selectedPattern = "";
    private int cyclesPerTime = 0;
    private int currentCount = 0;
    private Data.Environment e = new Data.Environment(30,30);
    private string theRadio = "";
    private bool isCollapsed = true;
    private bool isOpen = true;
    private string cells = "";
    public string[] PatternsList = new string[] {
        "Add the pattern A for All",
        "Add the pattern Bipole",
        "Add the pattern Pentadecathlon"
    };
    private int rowNumber = 0;
    private int columnNumber = 0;

    private Data.BioUnit u;
    private void ClickRadio(ChangeEventArgs args) {
        theRadio = args.Value.ToString();
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 147 "C:\Users\pzx98720\blazorserver01\Pages\Counter.razor"
                                 
        currentCount++;
    }
    private void IncrementCount()
    {
        currentCount++;
        e.nextConwayStep();
        
    }
    private void AddPattern()
    {
        if(selectedPattern == "aforall") {
            e.put_pattern(rowNumber, columnNumber,"aforall");
        }
        else if (selectedPattern == "bipole") {
            e.put_pattern(rowNumber, columnNumber,"bipole");
        }
        else if (selectedPattern == "pentadecathlon") {
            e.put_pattern(rowNumber, columnNumber,"pentadecathlon");
        }
    }
    private void NewCell() {
        int counter = 0;
        string[] cellList = cells.Split(new Char[] { ',', '\n' });

        while (counter < cellList.Length)
        {
            this.rowNumber = Int32.Parse(cellList[counter]);
            counter++;

            this.columnNumber = Int32.Parse(cellList[counter]);
            counter++;

            e.insert(rowNumber, columnNumber, new Data.BioUnit(rowNumber, columnNumber, e));
        }
    }
    private bool CellClick(int row, int col) {
        e.onOff(row, col);
        return true;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
