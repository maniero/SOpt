DATA itab TYPE STANDARD TABLE OF i
          WITH EMPTY KEY
          WITH NON-UNIQUE SORTED KEY sort_key COMPONENTS table_line.

itab = VALUE #( ( 2 ) ( 5 ) ( 1 ) ( 3 ) ( 4 ) ).

DATA(output) = ``.
DATA(idx) = lines( itab ).
WHILE idx > 0.
  READ TABLE itab INDEX idx USING KEY sort_key
             ASSIGNING FIELD-SYMBOL(<fs>).
  idx = idx  - 1.
  CHECK <fs> > 2.
  output = output && <fs> && ` `.
ENDWHILE.

cl_demo_output=>display( output ).
