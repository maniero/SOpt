c.execute("INSERT INTO products (name, description, costp, sellp)
              VALUES (?, ?, ?, ?)", (p_name, p_desc, float(p_costp), float(p_sellp)))
              
#https://pt.stackoverflow.com/q/110846/101
