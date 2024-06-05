<h1> Lego Inventory Manager <h1>
<h3> Uses Rebrickable API for browing lego catalouge of parts and sets and adding/editing personal collection </h3>
<h3> Rebrickable API: https://rebrickable.com/api/v3/docs/</h3>
<h3>I am not affiliated with Lego or Rebrickable in any way</h3>
<h3> Purpose of this:</h3>
  
  * Learn to use APIs in C# and ASP.NET
  
<h3>Using this:</h3>
  <ol>
    
    1. Fork and pull down
    2. Go to Rebrickable and create an account or Login
    3. Go to your user settings and generate an API key
    
    If using Visual Studio:
    1. Right click on LegoInventoryManager
    2. click "manage User Secrets"
    3. Add the following to secrets.json: "API_KEY": "Your API Key"
  </ol>
 
    
<h3> Known Bug: Currently the Rebrickable API returns an error if trying to use GET part list if the part list only has one type of part in it. If it has two or more unique parts it works fine.</h3>
  
<h2>Lists:</h2>
<h3> Lists are for a user's own personal collection. There are two types of lists, parts and sets. A part list is a list of individual Lego peices. A set lists is a list of Lego sets.</h3>
<h3>To create/edit/delete a list you will need a User token</h3>
<h3>TO add/edit contents of a list that already exists you need to have a User Token and the List ID of the list being changed</h3>

<h3>To get a User Token:</h3>
  <ol>
    
    1. Go to Rebrickable API: https://rebrickable.com/api/v3/docs/
    2. Scroll down to the "users" section
    3. Click POST /api/v3/users/_token/
    4. Enter your Rebrickable username and password
    5. Click "try it out"
    6. Save the generated user token somewhere safe, you will need this everytime you want to create/edit/delete a list or add/edit contents of a list that already exists
    
  </ol>
<h3> To get your List ID: </h3>
  <ol>
    
    1. Go to https://rebrickable.com
    2. Login
    3. Hover over "My Lego" at the top of the page
    4. Click "My Part Lists" or "My Set Lists"
    5. Click on the list you want on the left hand side
    6. The list number is seen in the url. 
    Example: https://rebrickable.com/users/USERNAME/partlists/123456/
    USERNAME will be your username and 123456 is the part list number
  </ol>

  
