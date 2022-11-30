import React, { useState } from 'react';
import axios from 'axios';


function App() {
  const [data, setData] = useState({})
  const [location, setLocation] = useState('')
  
  
  const url = `https://localhost:7226/api/jobprofile/getAlljob?number=${location}`
  const searchLocation = (event) => {
    if (event.key === 'Enter') {
      axios.get(url).then((response) => {
        setData(response.data)
        console.log(response.data)
      })
      //setLocation('')
    }
  }
  return (
    
    <div className="app">
      <div className='king'>
      <h1>JOB PROFILE</h1>
     
      </div>
      <div className="search">
        <input
          value={location}
          onChange={event => setLocation(event.target.value)}
          onKeyPress={searchLocation}
          placeholder='Enterid'
          type="text" />
      </div>
      
          <div className="location">   
          
            <p>   CANDIDATE NAME: {data.candidateName}</p>
          </div>
          
          <div className="description">
           <p>  DESIGNATON:  {data.designation}</p>
          </div>
          
          <div className="feels">
           <p className='bold'>  EXPERIENCE: {data.experience}</p>
          </div>
          <div className="humidity">
           <p className='bold' >  PROFILEABOUT: {data.profileAbout}</p>
          </div>
         
          </div>   
          
      


    
  );
}
export default App;