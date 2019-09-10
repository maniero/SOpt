  headers = {
     -- Remember that headers are *ignored* by smtp.send. 
     from = "Sicrano de Oliveira <sicrano@example.com>",
     to = "Fulano da Silva <fulano@example.com>",
     subject = "Here is a message with attachments"
  },
  body = {
    preamble = "If your client doesn't understand attachments, \r\n" ..
               "it will still display the preamble and the epilogue.\r\n" ..
               "Preamble will probably appear even in a MIME enabled client.",
    -- first part: no headers means plain text, us-ascii.
    -- The mime.eol low-level filter normalizes end-of-line markers.
    [1] = { 
      body = mime.eol(0, [[
        Lines in a message body should always end with CRLF. 
        The smtp module will *NOT* perform translation. However, the 
        send function *DOES* perform SMTP stuffing, whereas the message
        function does *NOT*.
      ]])
    },
    -- second part: headers describe content to be a png image, 
    -- sent under the base64 transfer content encoding.
    -- notice that nothing happens until the message is actually sent. 
    -- small chunks are loaded into memory right before transmission and 
    -- translation happens on the fly.
    [2] = { 
      headers = {
        ["content-type"] = 'image/png; name="image.png"',
        ["content-disposition"] = 'attachment; filename="image.png"',
        ["content-description"] = 'a beautiful image',
        ["content-transfer-encoding"] = "BASE64"
      },
      body = ltn12.source.chain(
        ltn12.source.file(io.open("image.png", "rb")),
        ltn12.filter.chain(
          mime.encode("base64"),
          mime.wrap()
        )
      )
    },
    epilogue = "This might also show up, but after the attachments"
  }
  
  --https://pt.stackoverflow.com/q/74559/101
