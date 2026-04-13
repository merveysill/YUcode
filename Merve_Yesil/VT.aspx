<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="VT.aspx.cs" Inherits="Merve_Yesil.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource2">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="Id" />
                <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                <asp:BoundField DataField="Sifre" HeaderText="Sifre" SortExpression="Sifre" />
                <asp:BoundField DataField="Adi" HeaderText="Adi" SortExpression="Adi" />
                <asp:BoundField DataField="Soyadi" HeaderText="Soyadi" SortExpression="Soyadi" />
                <asp:BoundField DataField="DOB" HeaderText="DOB" SortExpression="DOB" />
                <asp:BoundField DataField="Sehir" HeaderText="Sehir" SortExpression="Sehir" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MyVTConnectionString4 %>" SelectCommand="SELECT * FROM [myTB]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:websiteConnectionString2 %>" SelectCommand="SELECT * FROM [MyTB]"></asp:SqlDataSource>
    </p>
    <p>
    </p>
</asp:Content>
