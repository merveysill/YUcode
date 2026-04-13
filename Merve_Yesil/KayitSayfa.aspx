<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="KayitSayfa.aspx.cs" Inherits="Merve_Yesil.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            flex: 0 0 auto;
        }
        .auto-style3 {
            width: 192px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container">
         <table style="position: absolute top: 50% left: 40%">
          
           </tr>
            <tr>
                <td class="auto-style3">Adi:</td>
            <td>
                <asp:TextBox ID="txtAdi" runat="server"></asp:TextBox>
            </td>
           </tr>
              <tr>
                  <td class="auto-style3">Soyadi:</td>
            <td>
                <asp:TextBox ID="txtSoyadi" runat="server"></asp:TextBox>
            </td>
           </tr>
              <tr>
                  <td class="auto-style3">Email:</td>
            <td>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </td>
           </tr>
              <tr>
                  <td class="auto-style3">Dogum Tarih:</td>
            <td>
                <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
            </td>
           </tr>
              <tr>
                  <td class="auto-style3">Şehir:</td>
            <td>
                <asp:TextBox ID="txtSehir" runat="server"></asp:TextBox>
            </td>
           </tr>
              <tr>
                  <td class="auto-style3">Şifre:</td>
            <td>
                <asp:TextBox ID="txtSifre" runat="server"></asp:TextBox>
            </td>
           </tr>
   
            <tr>
                <td class="auto-style3">
                 <div class="auto-style1">
                         <asp:Button ID="BtnSubmit" runat="server" Text="Ekle" OnClick="BtnSubmit_Click" />       
                    &nbsp;<asp:Button ID="Button1" runat="server" Text="Değiştir" OnClick="Button1_Click" />
&nbsp;<asp:Button ID="Button2" runat="server" Text="Sil" OnClick="Button2_Click" />
                    </div>
                  </td> 
                <td>
                    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
             </tr>
             <tr>
                 <td class="auto-style3">veritabani</td>
                 <td>
                     
                         <AlternatingRowStyle BackColor="#DCDCDC" />
                         <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
                         <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
                         <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                         <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
                         <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                         <SortedAscendingCellStyle BackColor="#F1F1F1" />
                         <SortedAscendingHeaderStyle BackColor="#0000A9" />
                         <SortedDescendingCellStyle BackColor="#CAC9C9" />
                         <SortedDescendingHeaderStyle BackColor="#000065" />
                     </asp:GridView>
                         <br />
                         <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Id" DataSourceID="SqlDataSource1">
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
                         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyVTConnectionString3 %>" SelectCommand="SELECT * FROM [myTB]"></asp:SqlDataSource>
                         <br />
                         <br />
                         <br />
                 </td>
             </tr>
             <tr> 
                 <td class="auto-style3"> copy right MBBP</td>
             </tr>
            </table>
     </div>
</asp:Content>
