ObjectReader.read((char *)&reader.campo1, sizeof(reader.campo1));
ObjectReader.read((char *)&reader.campo2, sizeof(reader.campo2));
ObjectReader.read((char *)&reader.campo3, sizeof(reader.campo3));

struct __attribute__((packed)) nome { ... };

#pragma pack(push, 1)
struct nome { ... };
#pragma pack(pop)

//https://pt.stackoverflow.com/q/45097/101
