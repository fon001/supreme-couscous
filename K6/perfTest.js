import { sleep } from "k6";
import http from "k6/http";

export const options = {
  ext: {
    loadimpact: {
      distribution: {
        "amazon:us:ashburn": { loadZone: "amazon:ie:dublin", percent: 100 },
      },
    },
  },
  stages: [
    { target: 20, duration: "1m" },
    { target: 20, duration: "3m30s" },
    { target: 0, duration: "1m" },
  ],
  thresholds: {},
};

export default function main() {
  let response;

  // bpcal
  response = http.get("http://bpcalapp-dev.eu-west-1.elasticbeanstalk.com");

  // Automatically added sleep
  sleep(1);
}