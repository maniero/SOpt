public NotaFiscal Clone() {
    if (Object.ReferenceEquals(source, null)) {
        return default(NotaFiscal);
    }
    var deserializeSettings = new JsonSerializerSettings {ObjectCreationHandling = ObjectCreationHandling.Replace};
    return JsonConvert.DeserializeObject<NotaFiscal>(JsonConvert.SerializeObject(this), deserializeSettings);

 }
 
 //http://pt.stackoverflow.com/q/185452/101
