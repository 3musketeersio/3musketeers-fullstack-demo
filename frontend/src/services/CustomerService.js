import axios from "axios"

export default {
  async getCustomers(accessToken) {
    let res = await axios.get("https://localhost:8090/customers", {
      headers: {
        Authorization: `Bearer ${accessToken}`
      }
    }
    );
    return res.data;
  },
  async getCustomerSingle(id, accessToken) {

    let res = await axios.get("https://localhost:8090/customers/" + id, {
      headers: {
        Authorization: `Bearer ${accessToken}`
      }
    });
    return res.data;
  }
}