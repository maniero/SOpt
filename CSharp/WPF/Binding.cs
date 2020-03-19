<DataGrid AutoGenerateColumns="False" Height="Auto" Width="Auto" HorizontalAlignment="Left" Name="dataGridProdutos" ItemsSource="{Binding Path=carregarDados}" CanUserResizeRows="True" AlternatingRowBackground="GhostWhite"  AlternationCount="2" CanUserAddRows="False">
    <DataGrid.Columns>
        <DataGridTextColumn Binding="{Binding Path=idSocio}" Header="Número de Sócio" Width="Auto" IsReadOnly="True" />
        <DataGridTextColumn Binding="{Binding Path=SocioNome}" Header="Nome" Width="Auto" IsReadOnly="True" />
        <DataGridTextColumn Binding="{Binding Path=SocioDataNasc, StringFormat = d}" Header="Data de Nascimento" Width="*" IsReadOnly="True" />
    </DataGrid.Columns>
</DataGrid>

<!--https://pt.stackoverflow.com/q/164529/101
