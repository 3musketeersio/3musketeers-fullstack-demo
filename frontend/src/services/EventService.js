import axios from "axios"

export default {
  async getEvents(accessToken) {
    let res = await axios.get("http://localhost:8090/events", {
      headers: {
        Authorization: `Bearer ${accessToken}`
      }
    }
    );
    return res.data;
  },
  async getEventSingle(eventId, accessToken) {

    let res = await axios.get("http://localhost:8090/events/" + eventId, {
      headers: {
        Authorization: `Bearer ${accessToken}`
      }
    });
    return res.data;
  }
}