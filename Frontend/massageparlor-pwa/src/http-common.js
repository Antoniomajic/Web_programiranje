import axios from "axios";

export default axios.create({
    baseURL: "http://antoniomajic-001-site1.ftempurl.com/api/v1",
    headers: {
        "Content-Type": "application/json"
    }
});