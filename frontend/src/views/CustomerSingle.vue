<template>
  <div class="event-single">
    <section class="hero is-primary">
      <div class="hero-body">
        <div class="container">
          <h1 class="title">
            Customer Details
          </h1>
        </div>
      </div>
    </section>
    <section class="event-content">
      <div class="container">
        <p class="is-size-5"><strong>First Name:</strong> {{ event.firstName }}</p>
        <p class="is-size-5"><strong>Last Name:</strong> {{ event.lastName }}</p>
      </div>
    </section>
  </div>
</template>
<script>
  import CustomerService from '@/services/CustomerService.js'
  import { audience } from '../../auth_config.json'

  export default {
    name: 'CustomerSingle',

    data() {
      // NEW - initialize the event object
      return {
        event: {}
      }
    },

  created() {
    this.getEventData(); // call getEventData() when the instance is created
  },

  methods: {
    async getEventData() {
      let accessToken = ""
      try {
        accessToken = await this.$auth.getTokenSilently({
          audience: audience
        })
      } catch(err){
        if (err.error !== 'consent_required') {
          alert('Error while fetching access token. Check browser logs.')
          return console.log(err)
        }
        accessToken = await this.$auth.getTokenWithPopup({
          audience: audience
        })
      }
      console.log(accessToken)
      CustomerService.getCustomerSingle(this.$route.params.id, accessToken)
      .then(
        (event => {
          this.$set(this, "event", event);
        }).bind(this)
      )
    }
  }
}
</script>
<style lang="scss" scoped>
  .event-single {
    margin-top: 30px;
  }
  .hero {
    margin-bottom: 70px;
  }
</style>