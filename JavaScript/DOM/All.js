$('button:not(.remove)').on('click', function() {
  $('.alltest').css('all', $(this).text());
});

$('.remove').on('click', function() {
  $('.alltest').css('all', '');
});
.container {
  font-family: sans-serif;
  /* inherited */
  
  font-size: 1.5em;
  /* inherited */
  
  text-align: center;
  /* inherited */
  
  text-transform: uppercase;
  /* inherited */
  
  text-shadow: 1px 1px 1px black;
  /* inherited */
}

.parent {
  color: green;
  /* inherited */
  
  background-color: gainsboro;
  /* not inherited */
  
  width: 80%;
  /* not inherited */
  
  padding: 1em;
  /* not inherited */
  
  border: 5px solid #E18728;
  /* not inherited */
}
/* Styles for Pen, unrelated to all property demonstration */

button {
  margin-right: 1%;
  margin-bottom: .5em;
}
<script src="https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js"></script>
<button>initial</button>
<button>inherit</button>
<button>unset</button>
<button class="remove">remove "all" property</button>
<div class="container">
  <div class="parent">
    <div class="alltest">
      <p>Change this div's <code>all</code> value.</p>
    </div>
  </div>
</div>

//https://pt.stackoverflow.com/q/335015/101
