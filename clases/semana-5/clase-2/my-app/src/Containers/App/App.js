import React, { useState } from 'react';
import ListItem from '../../Components/ListItem'
import Form from '../../Components/Form'
import Card from '../Card'


const App = () => {
  const [title, setTitle] = useState("");

  return(
    <div>

      <Card />

    </div>
  );
}

export default App;
