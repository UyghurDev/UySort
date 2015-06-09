<%@ Page Title="ئۇيغۇرچە ئېلىپبە تەرتىپى بويىچە سورتلاش(Sorting by Uyghur Alphabet)" Language="C#" MasterPageFile="~/Common/Public.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="UySort_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <table cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td style="text-align: center">
                <br />
                ئۇيغۇرچە ئېلىپبە تەرتىپى بويىچە سورتلاش<br />
                Sorting by Uyghur Alphabet<br />
                <hr class="HorzentalLineHeader" dir="rtl" />
            </td>
        </tr>
        <tr>
            <td>
                 <table cellpadding="0" dir="rtl" 
                    style="border-collapse: collapse; width: 600px; border: 1px solid #d5ddf3" align="center">
                    <tr>
                        <td dir="ltr">
                            <asp:TextBox ID="txtWords" runat="server" Height="200px" TextMode="MultiLine" 
                                Width="600px" CssClass="TextBox">گۈل
دەرەخ
ئورمان
دېڭىز
تاغ
دەريا
يايلاق
ئېتىز
جاڭگال
قۇملۇق
باغ
چۆل
ئوت
ھاۋا
سۇ
تۇپراق
ۋەتەن
يۇرت
ئۇيغۇر
ئالىم
فارابى
ئۇلۇغبىك
مەھمۇد قەشقىرى
يۈسۈپ خاس ھاجىپ
ناۋائى
غازباي
تەۋپىق</asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: center">
                            <asp:Button ID="btnSort" runat="server"
                                Text="سورتلاش" onclick="btnSort_Click" />
                        </td>
                                        </tr>
                                       
                    <tr>
                        <td style="text-align: right">
                            ئىزاھات: تېكىست رامكىسىدىكى مەزمۇنلارنى قۇر بۇيىچە سورتلايدۇ.</td>
                                        </tr>
                                       
                                    </table>
                <br />
                مۇناسىۋەتلىك ئۇلىنىشلار<hr align="right" class="HorzentalLineLinks" />
                <br />
            </td>
        </tr>
    </table>
</asp:Content>

