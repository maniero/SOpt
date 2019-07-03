Dim certificateCollection As X509CertificateCollection = X509Certificate2UI.SelectFromCollection(Store.Certificates, "Caption", "Message", X509SelectionFlag.SingleSelection)

'https://pt.stackoverflow.com/q/49527/101
