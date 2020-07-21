public class CountyViewModel {
    [HiddenInput]
    public int? CountyId { get; set; }

    [DisplayName("County Name")] [StringLength(25)]
    public string CountyName { get; set; }

    [DisplayName("County URL")] [StringLength(255)]
    public string URL { get; set; }
}

public class ListAllCountiesViewModel {
    public string CountyName { get; set; }
    public IEnumerable<County> ListAllCounty { get; set; }
}

public class PropertyViewModel {
    public ListAllCountiesViewModel _listAllCountyViewModel { get; set; }
    public CountyViewModel _countyViewModel { get; set; }
}

//https://pt.stackoverflow.com/q/305207/101
