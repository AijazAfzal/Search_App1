<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Search_App._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        
        <asp:TextBox ID="txt_fn" runat="server"></asp:TextBox>
        
&nbsp;














&nbsp;<asp:Button ID="btn_srfn" runat="server" Text="Search" OnClick="btn_srfn_Click" />














    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_mn" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="search_mn" runat="server" Text="Search" OnClick="search_mn_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_ln" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="search_ln" runat="server" Text="Search" OnClick="search_ln_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txt_empro" runat="server"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Button ID="seacrh_eml" runat="server" Text="Search" OnClick="seacrh_eml_Click" />
&nbsp;
        <br />
        <br />
        From Date:<asp:TextBox ID="txt_fromdt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        To Date:<asp:TextBox ID="txt_todt" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="search_date" runat="server" Text="Search" OnClick="search_date_Click" /> 














    &nbsp;
        <br />
        <br />
        <asp:GridView ID="grd_tbl" runat="server"> 
        </asp:GridView> 
        <br />














    </div>


</asp:Content>
