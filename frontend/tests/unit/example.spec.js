import { expect } from 'chai'
import { shallowMount } from '@vue/test-utils'
import EventCard from '@/components/EventCard.vue'

describe('EventCard.vue', () => {
  it('renders props.msg when passed', () => {
    const msg = 'new message'
    const wrapper = shallowMount(EventCard, {
      event: { msg }
    })
    expect(wrapper.text()).to.include(msg)
  })
})
