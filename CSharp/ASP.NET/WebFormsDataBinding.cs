<asp:FormView ID="FormView1"
  DataSourceID="SqlDataSource1"
  DataKeyNames="ProductID"     
  RunAt="server">

  <ItemTemplate>
    <table>
      <tr>
        <td align="right"><b>Product ID:</b></td>       
        <td><%# Eval("ProductID") %></td>
      </tr>
      <tr>
        <td align="right"><b>Product Name:</b></td>     
        <td><%# Eval("ProductName") %></td>
      </tr>
      <tr>
        <td align="right"><b>Category ID:</b></td>      
        <td><%# Eval("CategoryID") %></td>
      </tr>
      <tr>
        <td align="right"><b>Quantity Per Unit:</b></td>
        <td><%# Eval("QuantityPerUnit") %></td>
      </tr>
      <tr>
        <td align="right"><b>Unit Price:</b></td>       
        <td><%# Eval("UnitPrice") %></td>
      </tr>
    </table>                 
  </ItemTemplate>                 
</asp:FormView>

<!--https://pt.stackoverflow.com/q/250158/101
