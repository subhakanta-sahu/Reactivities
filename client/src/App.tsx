import { List, ListItem, Typography } from "@mui/material";
import axios from "axios";
import { useEffect, useState } from "react";

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);

  useEffect(() => {
    axios
      .get<Activity[]>("https://localhost:5001/api/activities")
      .then((res) => setActivities(res.data));
  }, []);

  return (
    <>
      <Typography variant="h2">Reactivities</Typography>
      <div>
        <List>
          {activities &&
            activities.map((activity) => (
              <ListItem key={activity.id}>{activity.title}</ListItem>
            ))}
        </List>
      </div>
    </>
  );
}

export default App;
